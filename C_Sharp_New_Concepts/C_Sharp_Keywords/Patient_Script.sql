--  Calender-------------
if OBJECT_ID('tempdb.#temp_calendar') is not null
drop table #temp_calendar


create table #temp_calendar
(
	Date datetime
)

DECLARE @todate datetime, @fromdate datetime
SELECT @fromdate='2020-03-01', @todate='2020-03-31'

;WITH calendar (FromDate) AS (
    SELECT @fromdate AS Date
    UNION ALL
    SELECT DATEADD(day, 1, FromDate)
    FROM Calendar
    WHERE FromDate < @todate
)
insert into #temp_calendar 
SELECT * 
FROM calendar 


select * from #temp_calendar

--- Calender count------------

if OBJECT_ID('tempdb.#temp_calendar_Week_Date') is not null
drop table #temp_calendar_Week_Date

create table #temp_calendar_Week_Date
(
	Week_Number int,
	Wed_Date datetime
)

SET DATEFIRST 4
insert into #temp_calendar_Week_Date
SELECT DISTINCT 
    min(DATEPART(WEEK, #temp_calendar.Date) ) as Week_Number,DATEADD(wk, DATEDIFF(wk,0,#temp_calendar.Date), 2) Wed_Date

FROM 
    #temp_calendar
WHERE
    #temp_calendar.Date between convert(datetime,'01/03/2020',103) and convert(datetime,'31/03/2020',103)
	
	group by DATEADD(wk, DATEDIFF(wk,0,#temp_calendar.Date), 2)



select * from #temp_calendar_Week_Date


	--- patient count 
	
if OBJECT_ID('tempdb.#temp_Dates') is not null

drop table #temp_Dates

create table #temp_Dates
(
updatedDate datetime,
count int,
UpdatedBy uniqueidentifier
)

insert into #temp_Dates

select CareGapDetails_PriorYear_Logic.updatedDate,count(*) as count,CareGapDetails_PriorYear_Logic.UpdatedBy from CareGapDetails_PriorYear_Logic
group by CareGapDetails_PriorYear_Logic.updatedDate,CareGapDetails_PriorYear_Logic.UpdatedBy
order by CareGapDetails_PriorYear_Logic.updatedDate



if OBJECT_ID('tempdb.#temp_PatientCount_Week') is not null

drop table #temp_PatientCount_Week

create table #temp_PatientCount_Week
(
week_number int,
Total_Patients int,
UpdatedBy uniqueidentifier
)


SET DATEFIRST 4
insert into #temp_PatientCount_Week
SELECT DATEPART(WK,#temp_Dates.updatedDate) as week_number,case when sum(#temp_Dates.COUNT) is null then 0 else sum(#temp_Dates.COUNT) end  as Total_Patients,
#temp_Dates.UpdatedBy 
from #temp_Dates
where #temp_Dates.updatedDate between convert(datetime,'01/03/2020',103) and  convert(datetime,'31/03/2020',103)

group by  DATEPART(WK,#temp_Dates.updatedDate),#temp_Dates.UpdatedBy 


--- Final line calender and Patient

select * from #temp_calendar_Week_Date

select * from #temp_PatientCount_Week

select #temp_calendar_Week_Date.Week_Number,#temp_calendar_Week_Date.Wed_Date,#temp_PatientCount_Week.Total_Patients,#temp_PatientCount_Week.UpdatedBy from 
#temp_calendar_Week_Date inner join #temp_PatientCount_Week 
on #temp_calendar_Week_Date.Week_Number=#temp_PatientCount_Week.week_number

--- Add pivot For Date and User column you will get the final output


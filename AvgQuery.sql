



select C.Visited_on,C.Amount,CC.avg_Amount from COMPANY C
inner join 
(
select CC.Visited_on,AVG(CC.Amount) as avg_Amount from COMPANY CC
group by CC.Visited_on
)CC on C.Visited_on=CC.Visited_on


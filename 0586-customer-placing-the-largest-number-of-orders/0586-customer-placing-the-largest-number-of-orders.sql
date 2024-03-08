SELECT customer_number

FROM orders

GROUP BY customer_number
ORDER BY count(*) desc LIMIT 1;

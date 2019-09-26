insert into EMP values (2,'vikash',12,23456);
insert into EMP values (3,'vikash1',13,234567);
insert into EMP values (4,'vikash2',14,234568);
insert into EMP values (5,'vikash3',15,23456789);
insert into EMP values (6,'vikash4',17,234567890);
-------------------------
insert into EMPDTLS values (1,50000,'Software Eng');
insert into EMPDTLS values (2,50000,'Software Eng1');
insert into EMPDTLS values (3,50000,'Software Eng2');
insert into EMPDTLS values (4,50000,'Software Eng3');
insert into EMPDTLS values (5,50000,'Software Eng4');


select id,Name into #temptable1 from EMP;
select * from EMP order by 3 asc;
select 2 from emp;
select '21',* from EMPDTLS;
update EMP set Age = (case AGE when 12 then 14 else 50 end);
--not support in SQL : select id,decode (Name,'ujjwal', 'ujjwal verma','vikash','vikash verma') from EMP;  //https://www.techonthenet.com/oracle/functions/decode.php
select id,(case Name when 'ujjwal' then 'ujjwal kumar' when 'vikash' then 'vikash verma' else Name end) from EMP;
select id,(case Name when 'ujjwal' then CONCAT ('ujjwal kumar','@',age) when 'vikash' then 'vikash verma' else Name end) from EMP;

select sysdate from dual;

SELECT GETDATE();
SELECT SYSDATE FROM dual;
--Temp table
select * into #temptable1 from EMP;
select * from #temptable1;
update #temptable1 set Name = 'Vikash Verma' where Number = 23456
drop table #temptable1;

--Joins
select e.ID,e.NAME,e.AGE,edtls.Salary from EMP e join EMPDTLS edtls on e.Id = edtls.Id;
select e.ID,e.NAME,e.AGE,edtls.Salary into #temp from EMP e left join EMPDTLS edtls on e.Id = edtls.Id;
select * from #temp;

--all temp table including system generated
select * from tempdb.sys.objects
--temp table created by user
SELECT 
  name = SUBSTRING(t.name, 1, CHARINDEX('___', t.name)-1),
  t.id
FROM tempdb..sysobjects AS t
WHERE t.name LIKE '#%[_][_][_]%'
AND t.id = 
  OBJECT_ID('tempdb..' + SUBSTRING(t.name, 1, CHARINDEX('___', t.name)-1));

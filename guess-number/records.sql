select * from record_times2              
insert into record_times2 values ('04:04')    
select * from record_times2 where times like '%04'      
delete from record_times2 where times like '%04'
           
select * from record_times      
select * from record_times where times like '07:%'
insert into record_times values ('07:')
update record_times set times = '02:55' where id= 56
delete from record_times where times like '07:%'
update record_times set times = replace(times,'00:','') where times like '00:%'
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  
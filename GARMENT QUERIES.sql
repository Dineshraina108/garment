CREATE TABLE GARUREG(USID INT NOT NULL PRIMARY KEY,UNAME CHAR(20),USERNAME VARCHAR(20),PASS VARCHAR(20),REPASS VARCHAR(20),DOB VARCHAR(15),GENDER CHAR(8),MOBILENO NUMBER(10),EMAILID VARCHAR(20),ADDRESS VARCHAR(40),PRIVILAGE CHAR(1));
SELECT * FROM GARUREG;
DROP TABLE GARUREG;
INSERT INTO GARUREG VALUES(1,'Dinesh kumar','dinesh','Abc@123','Abc@123',to_date('10-06-1997','dd/mm/yyyy'),'Male','9874563210','ades@gmail.com','15, ram street, erode','Y');
commit;
update GARUREG set PRIVILAGE='N' WHERE USID=2;
delete from GARUREG WHERE USID=1;

CREATE TABLE TASKUSERDATA(USID INT NOT NULL REFERENCES GARUREG,CAREERID INT NOT NULL PRIMARY KEY,DEPT CHAR(20),PROCESS CHAR(30),POSITION CHAR(30),CRDATE VARCHAR(20));
SELECT *  FROM TASKUSERDATA; 
drop table TASKUSERDATA;

CREATE TABLE TASKPROJECT(PRJID INT NOT NULL PRIMARY KEY, PRJNAME CHAR(40),PRJLAN VARCHAR(20),STDATE VARCHAR(20), ENDATE VARCHAR(20));
SELECT *  FROM TASKPROJECT;

CREATE TABLE TMSTASK(TASKID INT NOT NULL PRIMARY KEY,TASKNAME VARCHAR(30),DURATION VARCHAR(30));
SELECT *  FROM TMSTASK;

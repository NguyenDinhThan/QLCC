create database QLCC

create table Department(
	iDepartmentID int not null AUTO_INCREMENT,
    sDepartmentName varchar(20),
    primary key(iDepartmentID)
);
CREATE TABLE employee (
  iEmployeeID INT NOT NULL AUTO_INCREMENT,
  iPositionID int ,
  iDepartmentID int ,
  sEmployeeFirstName VARCHAR(30) ,
  sEmployeeLastName VARCHAR(30) ,
  mEmployeePicture mediumblob, 
  sEmployeeSex VARCHAR(8) ,
  sEmployeeIDentityCard VARCHAR(20) UNIQUE,
  sEmployeePhone VARCHAR(20) UNIQUE,	
  sEmployeeAddress VARCHAR(50) ,
  PRIMARY KEY (iEmployeeID)
  
);
create table `position`(
	iPositionID int not null AUTO_INCREMENT,
    sPositionName varchar(20),
    primary key(iPositionID)
);
create table time_sheet (
	iTimeSheet int not null AUTO_INCREMENT,
    iEmployeeID int ,
	iDepartmentID int,
    dDateTimeIn DATETIME,
    dDateTimeOut DATETIME,
	iAllowOff int ,
	dWorkOvertime DATETIME,
	primary key(iTimeSheet)
);
create table month_report (
	dMonthReport DATE not null ,
    iEmployeeID int ,
    iDayWork int,
	iDayOff int ,
	isalary int ,
	primary key(dMonthReport)
);

alter table Employee add constraint fk_e_d_idd foreign key (iDepartmentID) REFERENCES Department(iDepartmentID);
alter table Employee add constraint fk_e_p_ipd foreign key (iPositionID) REFERENCES `position`(iPositionID);
alter table time_sheet add constraint fk_ts_e_ied foreign key (iEmployeeID) REFERENCES Employee(iEmployeeID);
alter table time_sheet add constraint fk_ts_d_idd foreign key (iDepartmentID) REFERENCES Employee(iDepartmentID);
alter table month_report add constraint fk_mr_e_ied foreign key (iEmployeeID) REFERENCES Employee(iEmployeeID);





--them Employee
create procedure add_Emp (in eid int(11), in pid int(11),in did int(11), in fn varchar(50), in lnn varchar(50),in s varchar(8),in ic varchar(20), in p varchar(20), in a varchar(50))
begin
INSERT INTO Employee(iEmployeeID,iPositionID,iDepartmentID,sEmployeeFirstName,sEmployeeLastName,sEmployeeSex,sEmployeeIDentityCard,sEmployeePhone,sEmployeeAddress) VALUES ( eid,pid,did,fn,lnn,s,ic,p,a) ;
end

--cap nhat Employee
CREATE PROCEDURE up_Emp (in eid int(11), in pid int(11),in did int(11), in fn varchar(50), in lnn varchar(50),in s varchar(8),in ic varchar(20), in p varchar(20), in a varchar(50))
begin
UPDATE Employee SET iPositionID = pid , iDepartmentID=did, sEmployeeFirstName = fn, sEmployeeLastName = lnn ,sEmployeeSex= s, sEmployeeIDentityCard= ic, sEmployeePhone=p, sEmployeeAddress = a where iEmployeeID = eid ;
end

--xoa Employee

CREATE PROCEDURE del_Emp (in eid int(11))
begin
DeLETE from Employee where iEmployeeID = ist ; 
end

--them Departtment

CREATE PROCEDURE add_Deps (in id int(11), in name varchar(20))
BEGIN
INSERT INTO Department(iDepartmentID,sDepartmentName) VALUES ( id,name) ;
END 

--cap nhat Departtment
CREATE PROCEDURE up_Deps (in id int(11), in name varchar(20))
BEGIN
UPDATE Department SET sDepartmentName = name where iDepartmentID = id;
END
--xoa Departtment
CREATE PROCEDURE del_deps (in id int(11))
BEGIN
DeLETE FROM Department where iDepartmentID = id ;
END 


--them position

CREATE PROCEDURE add_po (in id int(11), in name varchar(40))
BEGIN
INSERT INTO `position`(iPositionID,sPositionName) VALUES ( id,name) ;
END

--cap nhat position
CREATE PROCEDURE up_po (in id int(11), in name varchar(40))
BEGIN
UPDATE `positin` SET sPositionName = name where iPositionID = id;
END
--xoa position
CREATE PROCEDURE del_po (in id int(11))
BEGIN
DeLETE FROM `position` where iPositionID = id ;
END 

--them tai khoan
CREATE PROCEDURE add_user (in id varchar(50), in pass varchar(50))
BEGIN
INSERT INTO login(userID,password) VALUES ( id,pass) ;
END 
--xoa tai khoan
CREATE PROCEDURE del_user (in id varchar(50)
BEGIN
DeLETE FROM login where userID = id ;
END 
--doi pass
CREATE PROCEDURE up_pass (in pass1 varchar(50), in pass2 varchar(50), in pass3 varchar(50))
BEGIN
UPDATE login SET password = pass3 where password = pass2 and pass2=pass3;
END
--cham cong
CREATE PROCEDURE add_time (in id int(11), in sl int(11))
BEGIN
INSERT INTO chamcong(iEmployeeID,iDayWork) VALUES ( id,(select count(*)from time_sheet where time_sheet.iEmployeeID = id)) ;
END 

CREATE PROCEDURE update_time (in id int(11),)
BEGIN
UPDATE chamcong SET iDayWork = (select count(*)from time_sheet,chamcong where time_sheet.EmployeeID = id ) ;
END 


















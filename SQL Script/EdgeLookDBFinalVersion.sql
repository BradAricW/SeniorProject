create table Employee (
	employeeID varchar(11) NOT NULL,
    fname varchar(30),
	lname varchar(30),
    email varchar(50),
    pssword varchar(256),
    phone varchar(50),
    hoursAvail int,
	admin boolean,
	active boolean,
    primary key(employeeID));
    
create table Project (
	prjNo varchar(30) NOT NULL,
    prjLeader varchar(11),
    description varchar(255),
    deliverables varchar(255),
    hoursNeeded int,
	prjComplete boolean,
    primary key(prjNo),
    foreign key (prjLeader) references Employee (employeeID));
    
create table WorksOn (
	employeeID varchar(11) NOT NULL,
    prjNo varchar(30) NOT NULL,
	hours int,
    primary key(employeeID, prjNo),
    foreign key(employeeID) references Employee(employeeID),
    foreign key(prjNo) references Project(prjNo));
	
create table ProjectPhase (
	prjNo varchar(30) NOT NULL,
	prjPhase varchar(30) NOT NULL,
	phaseDueDate date,
	status varchar(255),
	primary key(prjNo, prjPhase),
	foreign key(prjNo) references Project(prjNo));
    
create table Notes (
	employeeID varchar(11) NOT NULL,
    prjNo varchar(30) NOT NULL,
	nDate varchar(30) NOT NULL,
    notes varchar(255),
    primary key(employeeID, prjNo, nDate),
    foreign key(employeeID) references Employee(employeeID),
    foreign key(prjNo) references Project(prjNo));
    
create table Vacation (
	employeeID varchar(11) NOT NULL,
    startDate date NOT NULL,
    endDate date,
    primary key(employeeID, startDate),
    foreign key(employeeID) references Employee(employeeID));

    DELIMITER ;;

CREATE PROCEDURE `Employee_Search`(
SearchValue varchar(45)
)
BEGIN
Select E.employeeID, E.fname, E.lname
FROM Employee E
Where E.fname like CONCAT('%',SearchValue,'%') || E.lname like CONCAT('%',SearchValue,'%') || E.employeeID like CONCAT ('%',SearchValue,'%');
END ;;
DELIMITER ;

DELIMITER ;;
CREATE PROCEDURE `Project_Search`(
SearchValue varchar(45)
)
BEGIN
select DISTINCT  E.fname as 'Leader First Name', E.lname as 'Leader Last Name',P.Description, P.prjNo, P.prjComplete as 'Complete'
from Project as P join Employee as E
	on E.employeeID = P.prjLeader
where 	P.prjNo like CONCAT('%', SearchValue,'%') || E.fname like CONCAT('%', SearchValue,'%')
|| 	P.Description LIKE Concat('%', SearchValue, '%') || E.lname like CONCAT('%',SearchValue,'%');
END ;;
DELIMITER ;

DELIMITER ;;
CREATE PROCEDURE `Search_By_Description`(SearchValue varchar(45))
BEGIN
select DISTINCT  E.fname as 'Leader First Name', E.lname as 'Leader Last Name',P.Description, P.prjNo, P.prjComplete as 'Complete'
from Project as P join Employee as E
	on E.employeeID = P.prjLeader
where P.Description LIKE Concat('%', SearchValue, '%');
END ;;
DELIMITER ;

DELIMITER ;;
CREATE PROCEDURE `Search_By_Lead`(SearchValue varchar(45))
BEGIN
select DISTINCT  E.fname as 'Leader First Name', E.lname as 'Leader Last Name',P.Description, P.prjNo, P.prjComplete as 'Complete'
from Project as P join Employee as E
	on E.employeeID = P.prjLeader
where 	E.fname like CONCAT('%', SearchValue,'%');
END ;;
DELIMITER ;

DELIMITER ;;
CREATE PROCEDURE `Search_By_Project`(SearchValue varchar(45))
BEGIN
select DISTINCT  E.fname as 'Leader First Name', E.lname as 'Leader Last Name',P.Description, P.prjNo, P.prjComplete as 'Complete'
from Project as P join Employee as E
	on E.employeeID = P.prjLeader
where 	P.prjNo like CONCAT('%', SearchValue,'%');
END ;;
DELIMITER ;
	
insert into Employee values("1", "Admin","Admin","admin@gmail.com","password","111-111-1111",0,1,1);
    
 
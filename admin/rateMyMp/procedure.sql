

/*procedure*/
/*
--use rateMyMP;
--use master

create table adminLogin(
id numeric,
userName varchar(20),
passWord varchar(20));


select * from adminLogin;

insert into adminLogin values(1,'Admin','Panel');

select * from country

insert into country values('america')


drop procedure countryIn

procedure to insert values in country table

exec countryIn INDIA
select * from country
delete from country



create procedure countryDel @country nvarchar(50)
as
begin
if exists(select * from country where country=@country)
delete from state where countryId=(select countryId from country where country=@country)
delete from country where country=@country


else

end
working......
CREATE PROCEDURE countryUp @countryName nvarchar(50)
AS
BEGIN
SET NOCOUNT ON;
	update country set @countryName
SELECT SCOPE_IDENTITY()
END


finished 

insert state



 exec stateIn 'SIKKIM', 4,'india'

select * from state
select state from state


if ((select state from state where state=@stateName)=1)

update state set 

create procedure stateIn @stateName nvarchar(100), @noOfConstituency tinyint, @countryName nvarchar(50)
AS
Begin
set nocount on
insert into state values((select countryId from country where country=@countryName),@stateName, @noOfConstituency)
end


select state from state where state='sikkim'
5

constituency

drop procedure constituencyIn

create procedure constituencyIn @constituency nvarchar(50),@state nvarchar(50) , @country nvarchar(50),@party nvarchar(20)
AS
BEGIN
INSERT into constituency values((select stateId from state where state=@state and countryId=(select countryId from country where country=@country )),@constituency,(select partyId from party where partyName=@party))
End


update state set noOfConstituency=1 where stateId=6

exec constituencyIn 'sikkim','sikkim','india'



select stateId from state where state='sikkim' and countryId=(select countryId from country where country='india' )

select * from district
delete from constituency

select * from constituency
select * from constituency



party
drop procedure partyIn
create procedure partyIn @party nvarchar(50),@abbreviation varchar(10),@totalMember smallint,@countryId int
as
begin
insert into party values(@party,@abbreviation,@totalMember,@countryId)
end

select * from party

exec partyIn 'yourParty1','yp1',10

--insert into party values ('myParty','mp',10)


ROLES

create procedure roleIn @role nvarchar(50)
as
begin
insert into roles values(@role)
end


select * from roles

exec roleIN FLAG




create procedure socialNetworkIn @socialNetwork nvarchar(50)
as
begin
insert into socialNetwork values(@socialNetwork)
end

select * from socialNetwork order by snTypeID

exec socialNetworkIn custom



--not sure talk to pathak

create procedure userIn @email nvarchar(50),@password nvarchar(50),@roleId tinyint,@firstname nvarchar(50),@lastName nvarchar(50), @socialNetwork bit,@socialNetworkId tinyint, @status bit
as 
begin
insert into userMaster values
end

admin see details of user

create procedure userView @guid bigint
as
begin
select * from userMaster where guid=@guid
end


drop procedure userViewAll


create procedure userViewAll
as
begin
select * from userMaster
end


exec userView 1

exec userViewAll


create procedure incr @tblName nvarchar(50), @id nvarchar(50)
as
begin
select max(@id)  from @tblName
end


select * from userMaster



mp details

create procedure mpIn @electedYear smallint, 
as
begin
end


create procedure districtAdd @districtName
as
begin
insert into district
end



--mp


drop procedure regMp


create procedure regMp @email nvarchar(50),@pasword nvarchar(50),@roleId tinyint,@firstName nvarchar(50),@middleName nvarchar(50),@lastName nvarchar(50),
@socialNetwork bit,@sntypeId tinyint,@status bit,@passcode smallint,@profilePic nvarchar(50),@countryId int,@constituencyId smallint,@electedYear smallint,
@partyId tinyInt,@phone nvarchar(10),@mobile nvarchar(10),@qualification nvarchar(100),@profession nvarchar(30),
@permenantAddr nvarchar(100), @permenantDistId tinyint, @permenantstateId tinyint, @currentAddr nvarchar(100), @currentDistId tinyint, @currentstateId tinyint

as
begin
insert into userMaster values( @email ,@pasword ,@roleId ,@firstName ,@middleName ,@lastName,@socialNetwork ,@sntypeId ,@status,@passcode ,@profilePic)
insert into mpDetails values((select guid from userMaster where email=@email),@countryId ,@constituencyId ,@electedYear ,@partyId ,@phone ,@mobile,@qualification ,@profession ,@permenantAddr ,  @permenantDistId, @permenantstateId  , @currentAddr, @currentstateId,@currentDistId) 
end


--fetching ids
--
select * from district

create procedure fetchpermDist @permenantDist nvarchar(50)
as
begin
select districtId from district where districtName=@permenantDist
end

create procedure fetchpermstate @permenantstate nvarchar(50)
as
begin
select stateId from state where state=@permenantstate
end


create procedure fetchcurstate @currentstate nvarchar(50)
as
begin
select districtId from district where districtName=@currentstate
end

create procedure fetchcurdist @currentDist nvarchar(50)
as
begin

select districtId from district where districtName=@currentDist

end
--
create procedure fetchconsti @constituency nvarchar(50)
as
begin

select constituencyId from constituency where constituency=@constituency

end


create procedure fetchSocial @socialNetworkBit nvarchar(20)
as
begin
select sntypeId from socialNetwork where sntype=@socialNetworkBit
end

create procedure fetchrole @role nvarchar(20)
as
begin

select roleId from roles where roleName=@role

end



create procedure fetchpartyid @party nvarchar(20)
as
begin
select partyId from party where partyName=@party
end


create procedure fetchcountryid @country nvarchar(20)
as
begin
select countryId from country where country=@country
end

select * from mpDetails














--fetch diffferent values



create procedure fetchDist
as
begin
select districtName from district
end


--execution
exec fetchDist
use rateMyMp

drop procedure fetchstate
create procedure fetchstate @countryName nvarchar(50)
as
begin
select state from state where countryId=(select CountryId from country where country=@countryName)
end



create procedure fetchconstituency
as
begin
select constituency from constituency
end





create procedure fetchSocialnetworks
as
begin
select snType from socialNetwork
end

create procedure fetchroles
as
begin
select roleName from roles
end

create procedure fetchparty
as
begin
select partyName from party
end


create procedure fetchcountry
as
begin
select country from country
end




*/





update party set countryId=1;
select * from party
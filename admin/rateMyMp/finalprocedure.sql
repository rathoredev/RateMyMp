--final procedures
--use ratemymp
/*


--state

drop procedure countryIn

create PROCEDURE countryIn @countryName nvarchar(50)
AS
BEGIN
	insert into country values(@countryName)
END

use rateMyMp
select * from country



create procedure stateIn @stateName nvarchar(100), @noOfConstituency tinyint, @countryName nvarchar(50)
AS
Begin
insert into state values((select countryId from country where country=@countryName),@stateName, @noOfConstituency)
end

drop procedure  constituencyIn

create procedure constituencyIn @constituency nvarchar(50),@stateId tinyint , @countryId int,@partyId tinyint
AS
BEGIN
INSERT into constituency values(@stateId,@constituency,@partyId)
End

select * from constituency
select * from constituency

exec constituencyIn vbhdfasj,'ANDAMAN & NICOBAR ISLES','INDIA','All India United Democratic Front'

select partyId from party where partyName='All India United Democratic Front'


create procedure districtIn @distName nvarchar(40),@stateName nvarchar(40)
as
Begin
insert into district values((select stateId from state where state=@stateName),@distName)
end












--fetch values from tables

create procedure fetchCountry
as
begin
select country,countryId from country
end





drop procedure fetchState



create procedure fetchstate @countryId nvarchar(50)
as
begin
select state, stateId from state where countryId=countryId
end

exec fetchstate 1

exec fetchState INDIA
exec fetchstate INDIA

drop procedure fetchDist

create procedure fetchDist @stateId tinyint
as
begin
select districtName,districtId from district where stateId=@stateId
end


drop procedure fetchconstituency

create procedure fetchconstituency @CountryId int,@stateId tinyint
as
begin
select constituency, constituencyId from constituency where stateId=(select stateId from state where stateId=@stateId and countryId=(select countryId from country where countryId=@countryId))
end

exec fetchconstituency 1 ,27


drop procedure fetchSocialNetworks

create procedure fetchSocialnetworks
as
begin
select snType,snTypeId from socialNetwork
end


drop procedure fetchparty
create procedure fetchparty @countryId int
as
begin
select partyName, partyId from party where countryId=@countryId
end

drop procedure fetchcountry


select * from country


*/




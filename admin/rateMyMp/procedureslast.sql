--procedures for country

--use rateMyMp

/*

select * from country



fetch values from tables

--COUNTRY

create procedure fetchCountry
as
begin
select country,countryId from country
end


--STATE
drop procedure fetchstate
create procedure fetchstate @countryId int
as
begin
select state, stateId from state where countryId=@countryId
end


--DISTRICT
drop procedure fetchDist
create procedure fetchDist @stateId tinyint
as
begin
select districtName,districtId from district where stateId=@stateId
end


--PARTY
drop procedure fetchparty
create procedure fetchparty @countryId int
as
begin
select partyName, partyId from party where countryId=@countryId
end








--insert data


--COUNTRY
DROP PROCEDURE COUNTRYiN
create PROCEDURE countryIn @countryName nvarchar(50)
AS
BEGIN
BEGIN TRY
	insert into country values(@countryName)
END TRY
BEGIN CATCH
SELECT ERROR_NUMBER() AS ErrorMsg
END CATCH
END
select * from country

EXEC COUNTRYIN INDIA


--STATE
select * from state
create procedure stateIn @stateName nvarchar(100), @noOfConstituency tinyint, @countryId int
AS
Begin
insert into state values(@countryId,@stateName, @noOfConstituency)
end

exec stateIn asdsd,12,1
select * from country





--CONSTITUENCY

create procedure constituencyIn @constituency nvarchar(50),@stateId tinyint , @countryId int,@partyId tinyint
AS
BEGIN
INSERT into constituency values(@stateId,@constituency,@partyId,@countryId)
End


update constituency set countryId=1



select * from constituency
select partyName from party where partyId=1


--PARTY


create procedure partyIn @party nvarchar(50),@abbreviation varchar(10),@totalMember smallint,@countryId int
as
begin
insert into party values(@party,@abbreviation,@totalMember,@countryId)
end





*/
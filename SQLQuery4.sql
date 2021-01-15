select LicenseImgSrc from dbo.Pharmacies

update dbo.Pharmacies set LicenseImgSrc=REPLACE(LicenseImgSrc,'\','/'),CommercialRegImgSrc=REPLACE(CommercialRegImgSrc,'\','/')
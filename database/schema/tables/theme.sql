USE [towers];

CREATE TABLE theme (
    Id UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID() PRIMARY KEY,
    Name VARCHAR(255) NOT NULL,
    BackgroundPrimaryColor VARCHAR(7) NOT NULL,
    BackgroundSecondaryColor VARCHAR(7) NOT NULL,
    BackgroundAccentColor VARCHAR(7) NOT NULL,
    ForegroundPrimaryColor VARCHAR(7) NOT NULL,
    ForegroundSecondaryColor VARCHAR(7) NOT NULL,
    ForegroundAccentColor VARCHAR(7) NOT NULL,
    CreatedBy UNIQUEIDENTIFIER DEFAULT NULL,
    LastModifiedBy UNIQUEIDENTIFIER DEFAULT NULL,
    CreatedOn DATETIME DEFAULT GETDATE(),
    LastModifiedOn DATETIME DEFAULT GETDATE()
);
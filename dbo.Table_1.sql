﻿CREATE TABLE [dbo].[T_Suppliers]
(
[SId] INT IDENTITY (100, 1) NOT NULL PRIMARY KEY,
    [SName] NCHAR(20) NOT NULL,
    [SAddress] NCHAR(20) NOT NULL,
    [SPhone] NCHAR(10) NOT NULL,
    [SWeb] VARCHAR(50) NOT NULL,
    [SEmail] VARCHAR(50) NOT NULL,
    [Contact] NCHAR(20) NOT NULL
);

-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/04/2016 18:20:45
-- Generated from EDMX file: D:\Kurs1SNB\01\SimpleWebForms\SimpleWebForms\Models\VoucherModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [VouchersDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_VoucherDetails_Accounts]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VoucherDetails] DROP CONSTRAINT [FK_VoucherDetails_Accounts];
GO
IF OBJECT_ID(N'[dbo].[FK_VoucherDetails_Vouchers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VoucherDetails] DROP CONSTRAINT [FK_VoucherDetails_Vouchers];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Accounts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Accounts];
GO
IF OBJECT_ID(N'[dbo].[VoucherDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VoucherDetails];
GO
IF OBJECT_ID(N'[dbo].[Vouchers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Vouchers];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Accounts'
CREATE TABLE [dbo].[Accounts] (
    [ID] uniqueidentifier  NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Type] bit  NOT NULL
);
GO

-- Creating table 'VoucherDetails'
CREATE TABLE [dbo].[VoucherDetails] (
    [ID] uniqueidentifier  NOT NULL,
    [VoucherID] uniqueidentifier  NOT NULL,
    [AccountID] uniqueidentifier  NOT NULL,
    [Text] nvarchar(100)  NOT NULL,
    [Amount] decimal(18,2)  NOT NULL,
    [Comment] nvarchar(max)  NULL
);
GO

-- Creating table 'Vouchers'
CREATE TABLE [dbo].[Vouchers] (
    [ID] uniqueidentifier  NOT NULL,
    [Date] datetime  NOT NULL,
    [Text] nvarchar(100)  NOT NULL,
    [Type] int  NOT NULL,
    [Amount] decimal(18,2)  NOT NULL,
    [Paid] bit  NOT NULL,
    [Scan] varbinary(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'Accounts'
ALTER TABLE [dbo].[Accounts]
ADD CONSTRAINT [PK_Accounts]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'VoucherDetails'
ALTER TABLE [dbo].[VoucherDetails]
ADD CONSTRAINT [PK_VoucherDetails]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Vouchers'
ALTER TABLE [dbo].[Vouchers]
ADD CONSTRAINT [PK_Vouchers]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [AccountID] in table 'VoucherDetails'
ALTER TABLE [dbo].[VoucherDetails]
ADD CONSTRAINT [FK_VoucherDetails_Accounts]
    FOREIGN KEY ([AccountID])
    REFERENCES [dbo].[Accounts]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VoucherDetails_Accounts'
CREATE INDEX [IX_FK_VoucherDetails_Accounts]
ON [dbo].[VoucherDetails]
    ([AccountID]);
GO

-- Creating foreign key on [VoucherID] in table 'VoucherDetails'
ALTER TABLE [dbo].[VoucherDetails]
ADD CONSTRAINT [FK_VoucherDetails_Vouchers]
    FOREIGN KEY ([VoucherID])
    REFERENCES [dbo].[Vouchers]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VoucherDetails_Vouchers'
CREATE INDEX [IX_FK_VoucherDetails_Vouchers]
ON [dbo].[VoucherDetails]
    ([VoucherID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
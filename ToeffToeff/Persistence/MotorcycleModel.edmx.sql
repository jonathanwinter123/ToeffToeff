
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/03/2018 11:36:30
-- Generated from EDMX file: C:\Users\sb\Source\Repos\ToeffToeff\ToeffToeff\Persistence\MotorcycleModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MotorcycleDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__Model__BrandID__25869641]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Model] DROP CONSTRAINT [FK__Model__BrandID__25869641];
GO
IF OBJECT_ID(N'[dbo].[FK__ModelPers__Model__2B3F6F97]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ModelPerson] DROP CONSTRAINT [FK__ModelPers__Model__2B3F6F97];
GO
IF OBJECT_ID(N'[dbo].[FK__ModelPers__Perso__2A4B4B5E]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ModelPerson] DROP CONSTRAINT [FK__ModelPers__Perso__2A4B4B5E];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Brand]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Brand];
GO
IF OBJECT_ID(N'[dbo].[Model]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Model];
GO
IF OBJECT_ID(N'[dbo].[ModelPerson]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ModelPerson];
GO
IF OBJECT_ID(N'[dbo].[Person]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Person];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Brand'
CREATE TABLE [dbo].[Brand] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(200)  NULL,
    [Description] varchar(250)  NULL,
    [FoundingDate] datetime  NULL,
    [Styledescription] varchar(250)  NULL
);
GO

-- Creating table 'Model'
CREATE TABLE [dbo].[Model] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(200)  NULL,
    [ModelSpecification] varchar(200)  NULL,
    [Price] decimal(19,4)  NULL,
    [Picture] varchar(max)  NULL,
    [BrandID] int  NULL
);
GO

-- Creating table 'ModelPerson'
CREATE TABLE [dbo].[ModelPerson] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [PersonID] int  NULL,
    [ModelID] int  NULL
);
GO

-- Creating table 'Person'
CREATE TABLE [dbo].[Person] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [FirstName] varchar(100)  NULL,
    [LastName] varchar(100)  NULL,
    [Birthdate] datetime  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'Brand'
ALTER TABLE [dbo].[Brand]
ADD CONSTRAINT [PK_Brand]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Model'
ALTER TABLE [dbo].[Model]
ADD CONSTRAINT [PK_Model]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ModelPerson'
ALTER TABLE [dbo].[ModelPerson]
ADD CONSTRAINT [PK_ModelPerson]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Person'
ALTER TABLE [dbo].[Person]
ADD CONSTRAINT [PK_Person]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [BrandID] in table 'Model'
ALTER TABLE [dbo].[Model]
ADD CONSTRAINT [FK__Model__BrandID__25869641]
    FOREIGN KEY ([BrandID])
    REFERENCES [dbo].[Brand]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Model__BrandID__25869641'
CREATE INDEX [IX_FK__Model__BrandID__25869641]
ON [dbo].[Model]
    ([BrandID]);
GO

-- Creating foreign key on [ModelID] in table 'ModelPerson'
ALTER TABLE [dbo].[ModelPerson]
ADD CONSTRAINT [FK__ModelPers__Model__2B3F6F97]
    FOREIGN KEY ([ModelID])
    REFERENCES [dbo].[Model]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ModelPers__Model__2B3F6F97'
CREATE INDEX [IX_FK__ModelPers__Model__2B3F6F97]
ON [dbo].[ModelPerson]
    ([ModelID]);
GO

-- Creating foreign key on [PersonID] in table 'ModelPerson'
ALTER TABLE [dbo].[ModelPerson]
ADD CONSTRAINT [FK__ModelPers__Perso__2A4B4B5E]
    FOREIGN KEY ([PersonID])
    REFERENCES [dbo].[Person]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ModelPers__Perso__2A4B4B5E'
CREATE INDEX [IX_FK__ModelPers__Perso__2A4B4B5E]
ON [dbo].[ModelPerson]
    ([PersonID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
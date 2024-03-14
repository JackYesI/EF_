
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/13/2024 22:56:37
-- Generated from EDMX file: D:\C#\ConsoleApp1\EF_\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Library_EF_];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Library'
CREATE TABLE [dbo].[Library] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [bookName] nvarchar(max)  NOT NULL,
    [page_count] int  NOT NULL,
    [autorsId] int  NOT NULL,
    [languagesId] int  NOT NULL
);
GO

-- Creating table 'autorsSet'
CREATE TABLE [dbo].[autorsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [autorName] nvarchar(max)  NOT NULL,
    [autorSurname] nvarchar(max)  NOT NULL,
    [age] int  NOT NULL
);
GO

-- Creating table 'languagesSet'
CREATE TABLE [dbo].[languagesSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [languageName] nvarchar(max)  NOT NULL,
    [countryesId] int  NOT NULL
);
GO

-- Creating table 'countryesSet'
CREATE TABLE [dbo].[countryesSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [country] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Library'
ALTER TABLE [dbo].[Library]
ADD CONSTRAINT [PK_Library]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'autorsSet'
ALTER TABLE [dbo].[autorsSet]
ADD CONSTRAINT [PK_autorsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'languagesSet'
ALTER TABLE [dbo].[languagesSet]
ADD CONSTRAINT [PK_languagesSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'countryesSet'
ALTER TABLE [dbo].[countryesSet]
ADD CONSTRAINT [PK_countryesSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [autorsId] in table 'Library'
ALTER TABLE [dbo].[Library]
ADD CONSTRAINT [FK_autorsbooks]
    FOREIGN KEY ([autorsId])
    REFERENCES [dbo].[autorsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_autorsbooks'
CREATE INDEX [IX_FK_autorsbooks]
ON [dbo].[Library]
    ([autorsId]);
GO

-- Creating foreign key on [languagesId] in table 'Library'
ALTER TABLE [dbo].[Library]
ADD CONSTRAINT [FK_languagesbooks]
    FOREIGN KEY ([languagesId])
    REFERENCES [dbo].[languagesSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_languagesbooks'
CREATE INDEX [IX_FK_languagesbooks]
ON [dbo].[Library]
    ([languagesId]);
GO

-- Creating foreign key on [countryesId] in table 'languagesSet'
ALTER TABLE [dbo].[languagesSet]
ADD CONSTRAINT [FK_countryeslanguages]
    FOREIGN KEY ([countryesId])
    REFERENCES [dbo].[countryesSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_countryeslanguages'
CREATE INDEX [IX_FK_countryeslanguages]
ON [dbo].[languagesSet]
    ([countryesId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
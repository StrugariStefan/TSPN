
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/12/2019 19:39:26
-- Generated from EDMX file: C:\Users\Stefan\Downloads\InfoFacultate\TSPN\Proiect\CarServiceAPI\Model\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Auto];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AutoSasiu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Autoes] DROP CONSTRAINT [FK_AutoSasiu];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Autoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Autoes];
GO
IF OBJECT_ID(N'[dbo].[Sasius]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sasius];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Autoes'
CREATE TABLE [dbo].[Autoes] (
    [AutoId] int IDENTITY(1,1) NOT NULL,
    [NumarAuto] nvarchar(10)  NOT NULL,
    [SerieSasiu] nvarchar(25)  NOT NULL,
    [ClientClientId] int  NOT NULL,
    [Sasiu_SasiuId] int  NOT NULL
);
GO

-- Creating table 'Sasius'
CREATE TABLE [dbo].[Sasius] (
    [SasiuId] int IDENTITY(1,1) NOT NULL,
    [CodSasiu] nvarchar(2)  NOT NULL,
    [Denumire] nvarchar(25)  NOT NULL
);
GO

-- Creating table 'Clients'
CREATE TABLE [dbo].[Clients] (
    [ClientId] int IDENTITY(1,1) NOT NULL,
    [Nume] nvarchar(15)  NOT NULL,
    [Prenume] nvarchar(15)  NOT NULL,
    [Adresa] nvarchar(50)  NOT NULL,
    [Localitate] nvarchar(10)  NOT NULL,
    [Judet] nvarchar(10)  NOT NULL,
    [Telefon] nvarchar(13)  NOT NULL,
    [Email] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Comandas'
CREATE TABLE [dbo].[Comandas] (
    [ComandaId] int IDENTITY(1,1) NOT NULL,
    [StareComanda] int  NOT NULL,
    [DataSystem] datetime  NOT NULL,
    [DataProgramare] datetime  NOT NULL,
    [DataFinalizare] datetime  NOT NULL,
    [KmBord] int  NOT NULL,
    [Descriere] nvarchar(1024)  NOT NULL,
    [ValoarePiese] decimal(10,2)  NOT NULL,
    [Auto_AutoId] int  NOT NULL,
    [Client_ClientId] int  NOT NULL
);
GO

-- Creating table 'DetaliuComandas'
CREATE TABLE [dbo].[DetaliuComandas] (
    [DetaliuComandaId] int IDENTITY(1,1) NOT NULL,
    [Comanda_ComandaId] int  NOT NULL
);
GO

-- Creating table 'Mecanics'
CREATE TABLE [dbo].[Mecanics] (
    [MecanicId] int IDENTITY(1,1) NOT NULL,
    [Nume] nvarchar(15)  NOT NULL,
    [Prenume] nvarchar(15)  NOT NULL
);
GO

-- Creating table 'Materials'
CREATE TABLE [dbo].[Materials] (
    [MaterialId] int IDENTITY(1,1) NOT NULL,
    [Denumire] nvarchar(50)  NOT NULL,
    [Cantitate] decimal(10,2)  NOT NULL,
    [Pret] decimal(10,2)  NOT NULL,
    [DataAprovizionare] datetime  NOT NULL
);
GO

-- Creating table 'Imagines'
CREATE TABLE [dbo].[Imagines] (
    [ImagineId] int IDENTITY(1,1) NOT NULL,
    [Titlu] nvarchar(15)  NOT NULL,
    [Descriere] nvarchar(256)  NOT NULL,
    [Data] datetime  NOT NULL,
    [Foto] varbinary(4096)  NOT NULL,
    [ImagineDetaliuComanda_Imagine_DetaliuComandaId] int  NOT NULL
);
GO

-- Creating table 'Operaties'
CREATE TABLE [dbo].[Operaties] (
    [OperatieId] int IDENTITY(1,1) NOT NULL,
    [Denumire] nvarchar(256)  NOT NULL,
    [TimpDeExecutie] decimal(6,2)  NOT NULL
);
GO

-- Creating table 'MecanicDetaliuComanda'
CREATE TABLE [dbo].[MecanicDetaliuComanda] (
    [Mecanics_MecanicId] int  NOT NULL,
    [MecanicDetaliuComanda_Mecanic_DetaliuComandaId] int  NOT NULL
);
GO

-- Creating table 'MaterialDetaliuComanda'
CREATE TABLE [dbo].[MaterialDetaliuComanda] (
    [Materials_MaterialId] int  NOT NULL,
    [MaterialDetaliuComanda_Material_DetaliuComandaId] int  NOT NULL
);
GO

-- Creating table 'OperatieDetaliuComanda'
CREATE TABLE [dbo].[OperatieDetaliuComanda] (
    [Operaties_OperatieId] int  NOT NULL,
    [OperatieDetaliuComanda_Operatie_DetaliuComandaId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [AutoId] in table 'Autoes'
ALTER TABLE [dbo].[Autoes]
ADD CONSTRAINT [PK_Autoes]
    PRIMARY KEY CLUSTERED ([AutoId] ASC);
GO

-- Creating primary key on [SasiuId] in table 'Sasius'
ALTER TABLE [dbo].[Sasius]
ADD CONSTRAINT [PK_Sasius]
    PRIMARY KEY CLUSTERED ([SasiuId] ASC);
GO

-- Creating primary key on [ClientId] in table 'Clients'
ALTER TABLE [dbo].[Clients]
ADD CONSTRAINT [PK_Clients]
    PRIMARY KEY CLUSTERED ([ClientId] ASC);
GO

-- Creating primary key on [ComandaId] in table 'Comandas'
ALTER TABLE [dbo].[Comandas]
ADD CONSTRAINT [PK_Comandas]
    PRIMARY KEY CLUSTERED ([ComandaId] ASC);
GO

-- Creating primary key on [DetaliuComandaId] in table 'DetaliuComandas'
ALTER TABLE [dbo].[DetaliuComandas]
ADD CONSTRAINT [PK_DetaliuComandas]
    PRIMARY KEY CLUSTERED ([DetaliuComandaId] ASC);
GO

-- Creating primary key on [MecanicId] in table 'Mecanics'
ALTER TABLE [dbo].[Mecanics]
ADD CONSTRAINT [PK_Mecanics]
    PRIMARY KEY CLUSTERED ([MecanicId] ASC);
GO

-- Creating primary key on [MaterialId] in table 'Materials'
ALTER TABLE [dbo].[Materials]
ADD CONSTRAINT [PK_Materials]
    PRIMARY KEY CLUSTERED ([MaterialId] ASC);
GO

-- Creating primary key on [ImagineId] in table 'Imagines'
ALTER TABLE [dbo].[Imagines]
ADD CONSTRAINT [PK_Imagines]
    PRIMARY KEY CLUSTERED ([ImagineId] ASC);
GO

-- Creating primary key on [OperatieId] in table 'Operaties'
ALTER TABLE [dbo].[Operaties]
ADD CONSTRAINT [PK_Operaties]
    PRIMARY KEY CLUSTERED ([OperatieId] ASC);
GO

-- Creating primary key on [Mecanics_MecanicId], [MecanicDetaliuComanda_Mecanic_DetaliuComandaId] in table 'MecanicDetaliuComanda'
ALTER TABLE [dbo].[MecanicDetaliuComanda]
ADD CONSTRAINT [PK_MecanicDetaliuComanda]
    PRIMARY KEY CLUSTERED ([Mecanics_MecanicId], [MecanicDetaliuComanda_Mecanic_DetaliuComandaId] ASC);
GO

-- Creating primary key on [Materials_MaterialId], [MaterialDetaliuComanda_Material_DetaliuComandaId] in table 'MaterialDetaliuComanda'
ALTER TABLE [dbo].[MaterialDetaliuComanda]
ADD CONSTRAINT [PK_MaterialDetaliuComanda]
    PRIMARY KEY CLUSTERED ([Materials_MaterialId], [MaterialDetaliuComanda_Material_DetaliuComandaId] ASC);
GO

-- Creating primary key on [Operaties_OperatieId], [OperatieDetaliuComanda_Operatie_DetaliuComandaId] in table 'OperatieDetaliuComanda'
ALTER TABLE [dbo].[OperatieDetaliuComanda]
ADD CONSTRAINT [PK_OperatieDetaliuComanda]
    PRIMARY KEY CLUSTERED ([Operaties_OperatieId], [OperatieDetaliuComanda_Operatie_DetaliuComandaId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Sasiu_SasiuId] in table 'Autoes'
ALTER TABLE [dbo].[Autoes]
ADD CONSTRAINT [FK_AutoSasiu]
    FOREIGN KEY ([Sasiu_SasiuId])
    REFERENCES [dbo].[Sasius]
        ([SasiuId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AutoSasiu'
CREATE INDEX [IX_FK_AutoSasiu]
ON [dbo].[Autoes]
    ([Sasiu_SasiuId]);
GO

-- Creating foreign key on [ClientClientId] in table 'Autoes'
ALTER TABLE [dbo].[Autoes]
ADD CONSTRAINT [FK_ClientAuto]
    FOREIGN KEY ([ClientClientId])
    REFERENCES [dbo].[Clients]
        ([ClientId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientAuto'
CREATE INDEX [IX_FK_ClientAuto]
ON [dbo].[Autoes]
    ([ClientClientId]);
GO

-- Creating foreign key on [Auto_AutoId] in table 'Comandas'
ALTER TABLE [dbo].[Comandas]
ADD CONSTRAINT [FK_ComandaAuto]
    FOREIGN KEY ([Auto_AutoId])
    REFERENCES [dbo].[Autoes]
        ([AutoId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ComandaAuto'
CREATE INDEX [IX_FK_ComandaAuto]
ON [dbo].[Comandas]
    ([Auto_AutoId]);
GO

-- Creating foreign key on [Client_ClientId] in table 'Comandas'
ALTER TABLE [dbo].[Comandas]
ADD CONSTRAINT [FK_ComandaClient]
    FOREIGN KEY ([Client_ClientId])
    REFERENCES [dbo].[Clients]
        ([ClientId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ComandaClient'
CREATE INDEX [IX_FK_ComandaClient]
ON [dbo].[Comandas]
    ([Client_ClientId]);
GO

-- Creating foreign key on [Comanda_ComandaId] in table 'DetaliuComandas'
ALTER TABLE [dbo].[DetaliuComandas]
ADD CONSTRAINT [FK_DetaliuComandaComanda]
    FOREIGN KEY ([Comanda_ComandaId])
    REFERENCES [dbo].[Comandas]
        ([ComandaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetaliuComandaComanda'
CREATE INDEX [IX_FK_DetaliuComandaComanda]
ON [dbo].[DetaliuComandas]
    ([Comanda_ComandaId]);
GO

-- Creating foreign key on [Mecanics_MecanicId] in table 'MecanicDetaliuComanda'
ALTER TABLE [dbo].[MecanicDetaliuComanda]
ADD CONSTRAINT [FK_MecanicDetaliuComanda_Mecanic]
    FOREIGN KEY ([Mecanics_MecanicId])
    REFERENCES [dbo].[Mecanics]
        ([MecanicId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [MecanicDetaliuComanda_Mecanic_DetaliuComandaId] in table 'MecanicDetaliuComanda'
ALTER TABLE [dbo].[MecanicDetaliuComanda]
ADD CONSTRAINT [FK_MecanicDetaliuComanda_DetaliuComanda]
    FOREIGN KEY ([MecanicDetaliuComanda_Mecanic_DetaliuComandaId])
    REFERENCES [dbo].[DetaliuComandas]
        ([DetaliuComandaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MecanicDetaliuComanda_DetaliuComanda'
CREATE INDEX [IX_FK_MecanicDetaliuComanda_DetaliuComanda]
ON [dbo].[MecanicDetaliuComanda]
    ([MecanicDetaliuComanda_Mecanic_DetaliuComandaId]);
GO

-- Creating foreign key on [Materials_MaterialId] in table 'MaterialDetaliuComanda'
ALTER TABLE [dbo].[MaterialDetaliuComanda]
ADD CONSTRAINT [FK_MaterialDetaliuComanda_Material]
    FOREIGN KEY ([Materials_MaterialId])
    REFERENCES [dbo].[Materials]
        ([MaterialId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [MaterialDetaliuComanda_Material_DetaliuComandaId] in table 'MaterialDetaliuComanda'
ALTER TABLE [dbo].[MaterialDetaliuComanda]
ADD CONSTRAINT [FK_MaterialDetaliuComanda_DetaliuComanda]
    FOREIGN KEY ([MaterialDetaliuComanda_Material_DetaliuComandaId])
    REFERENCES [dbo].[DetaliuComandas]
        ([DetaliuComandaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MaterialDetaliuComanda_DetaliuComanda'
CREATE INDEX [IX_FK_MaterialDetaliuComanda_DetaliuComanda]
ON [dbo].[MaterialDetaliuComanda]
    ([MaterialDetaliuComanda_Material_DetaliuComandaId]);
GO

-- Creating foreign key on [Operaties_OperatieId] in table 'OperatieDetaliuComanda'
ALTER TABLE [dbo].[OperatieDetaliuComanda]
ADD CONSTRAINT [FK_OperatieDetaliuComanda_Operatie]
    FOREIGN KEY ([Operaties_OperatieId])
    REFERENCES [dbo].[Operaties]
        ([OperatieId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [OperatieDetaliuComanda_Operatie_DetaliuComandaId] in table 'OperatieDetaliuComanda'
ALTER TABLE [dbo].[OperatieDetaliuComanda]
ADD CONSTRAINT [FK_OperatieDetaliuComanda_DetaliuComanda]
    FOREIGN KEY ([OperatieDetaliuComanda_Operatie_DetaliuComandaId])
    REFERENCES [dbo].[DetaliuComandas]
        ([DetaliuComandaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OperatieDetaliuComanda_DetaliuComanda'
CREATE INDEX [IX_FK_OperatieDetaliuComanda_DetaliuComanda]
ON [dbo].[OperatieDetaliuComanda]
    ([OperatieDetaliuComanda_Operatie_DetaliuComandaId]);
GO

-- Creating foreign key on [ImagineDetaliuComanda_Imagine_DetaliuComandaId] in table 'Imagines'
ALTER TABLE [dbo].[Imagines]
ADD CONSTRAINT [FK_ImagineDetaliuComanda]
    FOREIGN KEY ([ImagineDetaliuComanda_Imagine_DetaliuComandaId])
    REFERENCES [dbo].[DetaliuComandas]
        ([DetaliuComandaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ImagineDetaliuComanda'
CREATE INDEX [IX_FK_ImagineDetaliuComanda]
ON [dbo].[Imagines]
    ([ImagineDetaliuComanda_Imagine_DetaliuComandaId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
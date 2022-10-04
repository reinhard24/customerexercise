CREATE TABLE [dbo].[Customer] (
    [CusId]      INT           IDENTITY (1, 1) NOT NULL,
    [CusName]    NCHAR (50)    NOT NULL,
    [CusAddress] NCHAR (100)   NOT NULL,
    [CusPhone]   NVARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([CusId] ASC)
);


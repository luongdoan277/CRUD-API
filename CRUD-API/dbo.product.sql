
CREATE TABLE [dbo].[product] (
    [Id]    INT            NOT NULL,
    [Name]  NVARCHAR (255) NULL,
    [Qty]   INT            NULL,
    [Price] DECIMAL (8, 2) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


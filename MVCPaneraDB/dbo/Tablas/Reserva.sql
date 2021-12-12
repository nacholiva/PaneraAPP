CREATE TABLE [dbo].[reserva] (
    [ID]         INT          IDENTITY (1, 1) NOT NULL,
    [cantidad]   INT          NOT NULL,
    [producto]   VARCHAR (45) NOT NULL,
    [nombre]     VARCHAR (45) NOT NULL,
    [contacto]   VARCHAR (45) NOT NULL,
    [metodopago] VARCHAR (45) NOT NULL,
    [pagado]     VARCHAR (45) NULL,
    [entregado]  VARCHAR (45) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);
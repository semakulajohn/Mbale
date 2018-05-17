CREATE TABLE [dbo].[Customer]
(
	[CustomerId] BIGINT IDENTITY(1,1) NOT NULL,	
	[FirstName] [nvarchar](128) not NULL,
	[LastName]  [nvarchar](128) not NULL,
	[Email]		[nvarchar](128) not NULL,
	[PhoneNumber] [nvarchar](128) not NULL,
	[Deleted]	[bit] NULL,
	[CreatedBy] [nvarchar](128) NULL, 
    [UpdatedBy] [nvarchar](128) NULL,     
    [DeletedBy] [nvarchar](128) NULL,
	[CreatedOn]	[datetime] NULL,
	[TimeStamp]	[datetime] NOT NULL DEFAULT GETDATE(),	
	[DeletedOn]	[datetime] NULL,

    CONSTRAINT [PK_dbo.Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
),
CONSTRAINT [FK_Customer_CreatedBy] FOREIGN KEY ([CreatedBy]) REFERENCES [dbo].[AspNetUsers](Id),
CONSTRAINT [FK_Customer_UpdatedBy] FOREIGN KEY ([UpdatedBy]) REFERENCES [dbo].[AspNetUsers](Id),
CONSTRAINT [FK_Customer_DeletedBy] FOREIGN KEY ([DeletedBy]) REFERENCES [dbo].[AspNetUsers](Id),
)ON [PRIMARY]

# 기차와 승무원 정보 입력 프로그램
기차 정보 or 승무원 정보를 단순 입력 후 저장합니다. <br/>
그리고 내용을 수정하거나 삭제를 하는 프로그램입니다.

# 실행방법
1.로그인을 합니다.(ID: Admin / PW: Admin) <br/>
2."기차 정보 입력"에서 내용을 입력합니다. <br/>
3."승무원 정보 입력"에서 내용을 입력합니다.

# Query문 VS의 Local DB를 사용하였습니다.
```sql
CREATE TABLE [dbo].[TravelTbl] (
    [TrCode]      INT            IDENTITY (1, 1000) NOT NULL,
    [Train]       INT            NOT NULL,
    [Origin]      NVARCHAR (120) NOT NULL,
    [Destination] NVARCHAR (120) NOT NULL,
    [TrDate]      DATE           NOT NULL,
    [TrTime]      NVARCHAR (50)  NOT NULL,
    [Conducter]   INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([TrCode] ASC),
    CONSTRAINT [FK2] FOREIGN KEY ([Conducter]) REFERENCES [dbo].[ConducterTbl] ([CCode]),
    CONSTRAINT [FK1] FOREIGN KEY ([Train]) REFERENCES [dbo].[TrainTbl] ([TCode])
);

CREATE TABLE [dbo].[TrainTbl] (
    [TCode]     INT           IDENTITY (1, 1) NOT NULL,
    [TName]     TEXT          NOT NULL,
    [TNumber]   NVARCHAR (50) NOT NULL,
    [Capacity]  INT           NOT NULL,
    [InDate]    DATE          NOT NULL,
    [Condition] TEXT          NOT NULL,
    [Color]     TEXT          NOT NULL,
    PRIMARY KEY CLUSTERED ([TCode] ASC)
);

CREATE TABLE [dbo].[PassengerTbl] (
    [PCode]   INT            IDENTITY (1, 1) NOT NULL,
    [PName]   NVARCHAR (50)  NOT NULL,
    [PGender] NVARCHAR (50)  NOT NULL,
    [PDOB]    DATE           NOT NULL,
    [PPhone]  NVARCHAR (50)  NOT NULL,
    [PAdress] NVARCHAR (120) NOT NULL,
    PRIMARY KEY CLUSTERED ([PCode] ASC)
);

CREATE TABLE [dbo].[ConducterTbl] (
    [CCode]   INT            IDENTITY (1, 1) NOT NULL,
    [CName]   NVARCHAR (50)  NOT NULL,
    [CGender] NVARCHAR (50)  NOT NULL,
    [CDOB]    DATE           NOT NULL,
    [CPhone]  NVARCHAR (50)  NOT NULL,
    [CAdress] NVARCHAR (120) NOT NULL,
    [CEXp]    INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([CCode] ASC)
);

CREATE TABLE [dbo].[BookingTbl] (
    [BCode]     INT           IDENTITY (1, 500) NOT NULL,
    [Travel]    INT           NOT NULL,
    [Passenger] INT           NOT NULL,
    [BDate]     DATE          NOT NULL,
    [Cost]      INT           NOT NULL,
    [BStatus]   NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([BCode] ASC),
    CONSTRAINT [FK4] FOREIGN KEY ([Passenger]) REFERENCES [dbo].[PassengerTbl] ([PCode]),
    CONSTRAINT [FK3] FOREIGN KEY ([Travel]) REFERENCES [dbo].[TravelTbl] ([TrCode])
);
```

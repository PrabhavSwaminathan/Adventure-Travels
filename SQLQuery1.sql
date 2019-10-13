CREATE TABLE [dbo].[Booking] (
[BookingId] int IDENTITY(1,1) NOT NULL,
[UserId] NVARCHAR (128) NOT NULL,
[FlightId] int NOT NULL,
[NumberOfAdults] int NOT NULL,
[NumberOfKids] int NOT NULL,
[BookingAmount] int NOT NULL
PRIMARY KEY (BookingId),
FOREIGN KEY (UserId) REFERENCES AspNetUsers(Id),
FOREIGN KEY (FlightId) REFERENCES Flight(FlightId)
)
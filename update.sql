DELETE from [STATS] where [ID] = 4;

DELETE from [STATS] where [ID] = 5;

INSERT INTO [Stats]
           ([Name]
           ,[Details]
           ,[Source]
           ,[Stat]
           ,[PanelClass]
           ,[FontAwesomeIcon]
           ,[Category_Id])
     VALUES
           ("Births"
           ,"Number of people born in Philadelphia"
           ,"IDK"
           ,63.25
           ,"bg-success"
           ,"fa-birthday-cake"
           ,1);

GO           
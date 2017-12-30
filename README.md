# Linq query formatter

This is a simple formatter that gets your precompiled traced string and recomposes a valid SQL query to be run / tested on your SQL environment.


# Example
### Precompiled query:

<pre>
SELECT TOP (1) [t4].[id] AS [Id], [t4].[title] AS [Title], [t4].[text] AS [Text], [t4].[date] AS [Date], [t4].[timestamp] AS [DateAdded], [t4].[codes] AS [Scores], [t4].[entity_id] AS [EntityId], [t4].[aditional_id] AS [AditionalId], [t4].[name] AS [UserName], [t4].[email] AS [UserEmail]
FROM (
    SELECT [t0].[id], [t3].[date], [t0].[timestamp], [t1].[title], [t2].[text], [t0].[name], [t0].[email], [t0].[codes], [t0].[ent_id] AS [aditional_id], [t0].[ent_logical_level] AS [entity_id], [t0].[guid]
    FROM [dbo].[SOME_TABLE] AS [t0]
    INNER JOIN [dbo].[SOME_OTHER_TABLE] AS [t1] ON ([t0].[id] = [t1].[id]) AND (@p0 = [t1].[some_id])
    INNER JOIN [dbo].[SOME_OTHER_OTHER_TABLE] AS [t2] ON ([t0].[id] = [t2].[id]) AND (@p1 = [t2].[some_id])
    INNER JOIN [dbo].[SOME_OTHER_OTHER_OTHER_TABLE] AS [t3] ON ([t0].[id] = [t3].[id]) AND (@p2 = [t3].[some_join])
    ) AS [t4]
WHERE [t4].[guid] = @p3
-- @p0: Input Int (Size = -1; Prec = 0; Scale = 0) [1]
-- @p1: Input Int (Size = -1; Prec = 0; Scale = 0) [1]
-- @p2: Input VarChar (Size = 8000; Prec = 0; Scale = 0) [period]
-- @p3: Input UniqueIdentifier (Size = -1; Prec = 0; Scale = 0) [c4f914fd-a924-41ef-a030-7ea59b7e3539]
-- Context: SqlProvider(Sql2005) Model: AttributedMetaModel Build: 4.6.1055.0
</pre>

### Output:
<pre>
DECLARE @p0 Int;
DECLARE @p1 Int;
DECLARE @p2 VarChar(8000);
DECLARE @p3 UniqueIdentifier;
SET @p0 = 1;
SET @p1 = 1;
SET @p2 = 'period';
SET @p3 = 'c4f914fd-a924-41ef-a030-7ea59b7e3539';
SELECT TOP (1) [t4].[id] AS [Id], [t4].[title] AS [Title], [t4].[text] AS [Text], [t4].[date] AS [Date], [t4].[timestamp] AS [DateAdded], [t4].[codes] AS [Scores], [t4].[entity_id] AS [EntityId], [t4].[aditional_id] AS [AditionalId], [t4].[name] AS [UserName], [t4].[email] AS [UserEmail]
FROM (
    SELECT [t0].[id], [t3].[date], [t0].[timestamp], [t1].[title], [t2].[text], [t0].[name], [t0].[email], [t0].[codes], [t0].[ent_id] AS [aditional_id], [t0].[ent_logical_level] AS [entity_id], [t0].[guid]
    FROM [dbo].[SOME_TABLE] AS [t0]
    INNER JOIN [dbo].[SOME_OTHER_TABLE] AS [t1] ON ([t0].[id] = [t1].[id]) AND (@p0 = [t1].[some_id])
    INNER JOIN [dbo].[SOME_OTHER_OTHER_TABLE] AS [t2] ON ([t0].[id] = [t2].[id]) AND (@p1 = [t2].[some_id])
    INNER JOIN [dbo].[SOME_OTHER_OTHER_OTHER_TABLE] AS [t3] ON ([t0].[id] = [t3].[id]) AND (@p2 = [t3].[some_join])
    ) AS [t4]
WHERE [t4].[guid] = @p3
-- @p0: Input Int (Size = -1; Prec = 0; Scale = 0) [1]
-- @p1: Input Int (Size = -1; Prec = 0; Scale = 0) [1]
-- @p2: Input VarChar (Size = 8000; Prec = 0; Scale = 0) [period]
-- @p3: Input UniqueIdentifier (Size = -1; Prec = 0; Scale = 0) [c4f914fd-a924-41ef-a030-7ea59b7e3539]
-- Context: SqlProvider(Sql2005) Model: AttributedMetaModel Build: 4.6.1055.0
</pre>

# Screenshot
<img src="https://i.imgur.com/SLEkr4n.png" />


SELECT 
	[Автор] = FORMATMESSAGE('%s %s', last_name, first_name),
	[Книга] = Books.title
FROM Authors, Books
WHERE 
	Authors.id = Books.author
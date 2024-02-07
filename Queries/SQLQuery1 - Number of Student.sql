SELECT group_name, learning_days, direction_name, [number_of_students] = COUNT(stud_id)
FROM Groups JOIN Directions ON direction = direction_id
JOIN Students ON [group] = [group_id] 
GROUP BY [group_name], [learning_days], [direction_name]
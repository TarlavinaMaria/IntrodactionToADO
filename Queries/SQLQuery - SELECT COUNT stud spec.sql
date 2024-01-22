USE PD_212
SELECT COUNT(stud_id) 
                            FROM Students JOIN Groups ON [group] = group_id 
                            JOIN Directions ON direction = direction_id
                            WHERE direction_name LIKE 'Разработка программного обеспечения'
                            GROUP BY direction_id
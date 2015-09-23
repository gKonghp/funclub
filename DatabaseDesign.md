employee - employeeID, username, password, position
^ staff, manager

teacher - teacherID, name, gender

student - studentID, membershipID, phone numer, email, enroll month,
^course to be registered

CourseCategory - categoryID, name

studentCourse - studentID, courseID

course - CourseID, name, description, quota, weekday, monthly fee, room, techerID, start time, 
		end time, material cost, teacher rate, operating charges, categoryID

mebership - mebershipID, type, discount

promotion - promotionID, name, description, additionalDiscount, start time, end time, active

profitMargin - Percentage
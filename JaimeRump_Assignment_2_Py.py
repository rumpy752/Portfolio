"""
	author: Jaime Rump	T00619701
	date: 2023-04-06
	filename: password_generator.py
	
	This program reads three values from the user, including their first and last name, and student ID.  
	The program will then use this input to generate a username for the student. The program also prompts the user
	to set a password and verifys the password against a set of rules. 
"""

# Collects user input 
first_name = input("What is your first name?: ")
print("Hi " + first_name)
last_name = input("What is your last name?: ")
student_ID = input("What is your student ID?: ")
print(". . . .  generating username . . . .")

# Returns the student's login name as a string
def get_login_name():
	if len(first_name) < 3:
		first = first_name
	else:
		first = first_name[:3]
	if len(last_name) < 3:
		last = last_name
	else:
		last = last_name[:3]
	if len(student_ID) < 3:
		id = student_ID
	else:
		id = student_ID[-3:]

	username = first + last + id
	print("Your username is: " + username)

get_login_name()

print("Next, you need to set a password for your account. ")

# Collect user input and verify the password adheres to the set of rules provided
def verify_password():
	while True:
		password = input("Enter your password: ")
		if len(password) < 7 or not any(char.isdigit() for char in password) \
			or not any(char.isupper() for char in password) \
			or not any(char.islower() for char in password):
			print("Invalid password. Please make sure your password contains at least 7 characters, "
				 "one uppercase letter, one lowercase letter, and one digit.")
		else:
			print(password)
			print("Password accepted!")
			break

verify_password()





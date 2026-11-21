import json
import sys
import sqlite3

from services.records import login_user, register_user

def main():
	try: 
		request = json.loads(sys.stdin.read())
		if request.get("action") == "login":
			username = request.get("username","")
			password = request.get("password","")
			
			user = login_user(username, password)

			if user: 
				response = {
					"success":True,
					"user_id": user[0],
					"name": user[1],
					"role": user[4]
				}
			else: 
				response = {
					"success": False,
					"message": "Invalid username or password."
			
				}
		elif request.get("action") == "register":
			user_id = request.get("user_id", "")
			name = request.get("name", "")
			email = request.get("email", "")
			department = request.get("department", "")
			user_type = request.get("user_type", "")
			username = request.get("username", "")
			password = request.get("password", "")

			try:
				registered = register_user(
					user_id,
					name,
					email,
					department,
					user_type,
					username,
					password
				)

				if registered:
					response = {
						"success": True,
						"message": "Registration successful!"
					}
				else:
					response = {
						"success": False,
						"message": "Registration failed."
					}

			except sqlite3.IntegrityError:
				response = {
					"success": False,
					"message": "User ID or username already exists, or a database constraint was violated."
				}
		else:
			response = {
				"success": False,
				"message": "Unknown action."
			}
	except Exception: 
		response = {
			"success":False,
			"message": "Unable to process request."
		}
	print(json.dumps(response))

if __name__ == "__main__":
	main()
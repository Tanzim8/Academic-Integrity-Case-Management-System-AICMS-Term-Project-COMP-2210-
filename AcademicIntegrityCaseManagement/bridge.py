import json
import sys

from services.records import login_user

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
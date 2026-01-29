POST /auth/register
POST /auth/login
GET  /users/xxx

<br>

**Example**
POST /auth/register
{
  "email": "user@email.com",
  "password": "StrongPassword123"
}

201 Created
{
  "userId": "guid"
}

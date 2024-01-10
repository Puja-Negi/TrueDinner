# True Dinner API

- [Buber Dinner API](#buber-dinner-api)
  -[Auth](#auth)
   -[Register](#register)
    -[Register Request](#register-request)
     -[Register Response](#register-response)
    -[Login](#login)
     -[Login Request](#login-request)
     -[Login Response](#login-response)


## Auth
### Register

```js
POST {{host}}/auth/register
```
#### Register Request

```json
{
    "firstname": "Puja",
    "lastname": "Lama",
    "email": "Puja@gmail.com",
    "password": "Puja123"
}
```

#### Register Response
```js
200 OK
```

```json
{
    "id":"d89c2d9a-eb3e-4075-95ff-b920b55aa104",
   "firstname": "Puja",
    "lastname": "Lama",
    "email": "Puja@gmail.com",
    "token": "eyJhb..z9dqcnXoY"
}
```

### Login
```js
POST {{host}}/auth/login
```
#### Login Request

```json
{
    "email": "Puja@gmail.com",
    "password": "Puja123"
}
```



#### Login Response
```js
200 OK
``` 

```json
{
    "id":"d89c2d9a-eb3e-4075-95ff-b920b55aa104",
    "firstname": "Puja",
    "lastname": "Lama",
    "email": "Puja@gmail.com",
    "token": "eyJhb..hbbQ"
}
```
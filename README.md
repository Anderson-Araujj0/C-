# API com Autenticação JWT - C#

Essa é uma API simples construída com ASP.NET Core que implementa Autenticação JWT para proteger os endpoints. O projeto tem como objetivo demonstrar como criar e autenticar usuários utilizando tokens JWT.

## Funcionalidades

- POST /api/auth/login: Realiza o login de um usuário e retorna um token JWT.
- GET /api/user/profile: Endpoint protegido, só acessível com um token JWT válido.


# Library_BookAPI

Library_BookAPI is a RESTful API project built in .NET Core that allows management of library book data. The project is configured to use a PostgreSQL database with Npgsql package for data storage. Supports HTTP verbs, input validation, and custom constraints for CRUD operations, handles PATCH requests effectively for data tracking.

## Packages Used

- `Microsoft.EntityFrameworkCore`
- `Newtonsoft.Json`
- `Swashbuckle.AspNetCore.Swagger`
- `Npgsql`
- `Serilog`

## API Endpoints

- **GET**: Retrieve a list of all books.
- **GET**: Retrieve a specific book by its ID.
- **POST**: Create a new book.
- **PUT**: Update an existing book.
- **DELETE**: Delete a book.

📌 Personal Finance Tracker API



Overview

A backend-focused REST API for tracking personal financial data, designed to reflect real-world production practices: secure authentication, clean API contracts, test automation, and cloud readiness.

The project is intentionally built using vertical slices to deliver end-to-end functionality incrementally, rather than isolated layers.



🎯 Goals

- Design a secure, API-first backend

- Practice authentication, authorization, and data isolation

- Implement automated testing at multiple levels

- Prepare the application for cloud deployment (Azure)

- Simulate real-world integration and analytics use cases

  

🧱 Architecture & Approach

- RESTful API following clean separation of concerns

- Vertical slice architecture (feature-based, end-to-end)

- JWT-based authentication and authorization

- OpenAPI (Swagger) for API documentation

- Strong emphasis on testability and maintainability
  


🔐 Core Features

- User Management (Sprint 1)
   * User registration & authentication
   * JWT-based access control
   * Secure password handling
   * Profile management
   * Account deletion

- Income Transactions (Sprint 2)
   * Income category management
   * Income creation, update, deletion
   * User-scoped data isolation

- Analytics & Integration (Sprint 3)
   * Monthly income summaries
   * Aggregated financial metrics
   * CSV import/export
   * External system integration (API-based)
     


🧪 Testing Strategy

- Unit tests for business logic and validation

- Integration tests for API endpoints and data flow

- Playwright API tests for end-to-end verification

- Authentication and authorization tested explicitly

  

☁️ Cloud & DevOps Readiness

- Designed with Azure fundamentals in mind

- Environment-based configuration

- Secrets externalized (future Azure Key Vault integration)

-  Prepared for deployment on Azure App Service

  

📄 API Documentation

- OpenAPI / Swagger UI available

- Clear request/response contracts

- HTTP status codes aligned with REST best practices



🚀 Why This Project

This project is built to demonstrate:

- Backend and API design skills

- Integration-ready architecture

- Test-driven thinking

- Cloud-aware decision making

It reflects how APIs are built, tested, and evolved in real production environments, not just tutorials.

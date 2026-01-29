
# Architecture Overview

## Purpose
This document describes the high-level architecture of the Personal Finance Tracker API,
including authentication flow, core components, and design decisions.

## Architectural Style
- RESTful API
- Vertical slice architecture (feature-based)
- Stateless authentication using JWT

## Key Components
- API Controllers
- Application Services
- Domain Models
- Persistence Layer
- Authentication & Authorization

## Authentication Overview
The system uses JWT-based authentication.
Access to protected resources requires a valid access token.

(See diagrams in /docs/diagrams)

## Deployment Considerations
- Environment-based configuration
- Cloud-ready design aligned with Azure fundamentals

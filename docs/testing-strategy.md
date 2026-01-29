# Test Strategy

## Objectives
- Ensure API correctness and reliability
- Validate authentication and authorization boundaries
- Prevent regressions in core user flows

## Test Levels

### Unit Tests
- Business logic
- Validation rules
- Token generation

### Integration Tests
- API endpoints
- Database interactions
- Authentication flows

### End-to-End API Tests
- Register → Login → Access protected endpoint
- Implemented using Playwright (API mode)

## Scope
Critical user flows are always covered by automated tests.

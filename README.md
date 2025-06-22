# 🧩 Domain.SharedKernel

**Domain.SharedKernel** is a clean, reusable shared library designed for Domain-Driven Design (DDD) applications. It encapsulates core domain logic, base entity definitions, ID generation, and abstraction contracts that can be shared across multiple bounded contexts or services.

---

## 📦 What's Included

### ✅ BaseEntity

A common abstract base class for domain entities, providing:

- Identity management
- Domain event support (e.g., integration with MediatR)

Useful for maintaining consistency and reducing duplication across aggregate roots and entities.

---

### 🔐 HashHelper

A utility class for generating secure hashes

---

### ❄️ Snowflake ID Generator
---

### 🧩 Core Abstractions

The library includes foundational interfaces to support clean architecture and separation of concerns:

- `IAggregateRoot` – Marks an entity as an aggregate root.
- `ICurrentUser` – Provides user context abstraction (e.g., `UserId`, `TenantId`).
- `IUnitOfWork` – Defines atomic transaction boundaries across repositories.

---

## 📘 Why Use a Shared Kernel?

Following the Shared Kernel pattern in DDD provides:

- 🔁 **Consistency** in entity and contract definitions
- 🧼 **Purity** by isolating domain logic from infrastructure
- 🔄 **Reusability** across microservices or modules
- 📐 **Clarity** through clearly defined interfaces

---

## 📄 License

MIT License


# 🧩 Domain.SharedKernel

**Domain.SharedKernel** is a clean, reusable shared library designed for Domain-Driven Design (DDD) applications. It encapsulates core domain logic, base entity definitions, ID generation, and abstraction contracts that can be shared across multiple bounded contexts or services.

---

## 📦 Installation

Install it from NuGet:

### .NET CLI

```bash
dotnet add package Andrew.Domain.SharedKernel --version 1.0.0
````

### Package Manager

```powershell
NuGet\Install-Package Andrew.Domain.SharedKernel -Version 1.0.0
```

---

## 📦 What's Included

### ✅ BaseEntity

A common abstract base class for domain entities, providing:

* Identity management
* Domain event support (e.g., integration with MediatR)

This helps maintain consistency and reduce duplication across aggregate roots and entities.

---

### 🔐 HashHelper

A utility class for generating secure hashes, such as:

* SHA256
* MD5

Useful for password storage, token generation, and data integrity checks.

---

### ❄️ Snowflake ID Generator

Generates globally unique, time-based 64-bit identifiers using the Snowflake algorithm, ideal for distributed systems.

---

### 🧩 Core Abstractions

The library provides key interfaces for clean domain architecture:

* `IAggregateRoot` – Indicates an aggregate root in the domain model.
* `ICurrentUser` – Provides access to user context such as `UserId`, `TenantId`.
* `IUnitOfWork` – Defines transactional boundaries for repository operations.

---

## 📘 Why Use a Shared Kernel?

The Shared Kernel pattern promotes:

* 🔁 **Consistency** in domain design across projects
* 🧼 **Purity** by decoupling domain logic from infrastructure
* 🔄 **Reusability** of common logic across microservices
* 📐 **Clarity** through well-defined contracts and interfaces

---

## 📄 License

MIT License

---

## 🤝 Contributing

Contributions are welcome! Feel free to open issues or submit pull requests to improve or extend the library.

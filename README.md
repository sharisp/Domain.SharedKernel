# 🧩 Domain.SharedKernel

**Domain.SharedKernel** is a clean, reusable shared library tailored for Domain-Driven Design (DDD) applications. It encapsulates core domain logic, base entity definitions, Snowflake ID generation, and abstraction contracts—ideal for use across multiple bounded contexts or microservices.

---

## 📦 Installation

Install via NuGet:

### .NET CLI

```bash
dotnet add package Andrew.Domain.SharedKernel
```

### Package Manager

```powershell
NuGet\Install-Package Andrew.Domain.SharedKernel
```

---

## 🚀 Getting Started

### 1. Install in the **Domain Layer** of your solution.

### 2. Add configuration to `appsettings.json`:

```json
"Snowflake": {
  "WorkerId": 1
}
```

> ℹ️ Use **different WorkerIds** for each microservice instance or physical machine to avoid ID collisions.

### 3. Register services via Dependency Injection (in Infra layer or `Program.cs`):

```csharp
services.AddDomainShardKernelCollection(configuration);
```

---

## 📦 What's Included

### ✅ `BaseEntity`

A common abstract base class for domain entities, offering:

* Unique identifier with Snowflake ID generation
* Domain event support (using [MediatR])

### 🔐 `HashHelper`

A utility class for secure hash generation:

* `SHA256`
* `MD5`

Useful for token generation, password hashing, and more.

### ❄️ Snowflake ID Generator

Generates globally unique 64-bit IDs based on time and machine identity. Perfect for distributed systems that require high-performance and collision-free ID generation.

### 🧩 Core Domain Abstractions

Includes key interfaces for domain architecture:

* `IAggregateRoot` – Marks an entity as an aggregate root.
* `ICurrentUser` – Access the current user context (`UserId`, `TenantId`, etc.).
* `IUnitOfWork` – Defines transactional boundaries for your repositories.

---

## 💡 Why Use a Shared Kernel?

Implementing a Shared Kernel brings:

* 🔁 **Consistency** across bounded contexts
* 🧼 **Separation** of domain logic from infrastructure concerns
* 🔄 **Reusability** across projects and microservices
* 📐 **Clarity** through standard interfaces and patterns

---

## 📄 License

MIT License

---

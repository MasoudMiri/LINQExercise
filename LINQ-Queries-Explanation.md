# LINQ Queries Explanation

در این فایل، تمامی کوئری‌های LINQ استفاده شده در پروژه به همراه توضیحات آن‌ها آورده شده است.

---

## 1. Get Products By Category

### Service

```csharp
public IEnumerable<Product> GetProductsByCategory(Categories category)
{
    return _repository.GetByCategory(category);
}
```

### Repository

```csharp
public IEnumerable<Product> GetByCategory(Categories category)
{
    return _products.Where(p => p.Category == category);
}
```

### Explanation

متد `Where` محصولاتی را فیلتر می‌کند که دسته‌بندی آن‌ها با مقدار ورودی برابر باشد.

---

## 2. Get Most Expensive Product

### Service

```csharp
public Product? GetMostExpensiveProduct()
{
    return _repository.GetAll()
                      .OrderByDescending(p => p.Price)
                      .FirstOrDefault();
}
```

### Explanation

متد `OrderByDescending` محصولات را بر اساس قیمت به صورت نزولی مرتب می‌کند و سپس `FirstOrDefault` اولین محصول (گران‌ترین محصول) را برمی‌گرداند.

---

## 3. Get Total Price

### Service

```csharp
public decimal GetTotalPrice()
{
    return _repository.GetAll()
                      .Sum(p => p.Price);
}
```

### Explanation

متد `Sum` مجموع قیمت تمامی محصولات را محاسبه می‌کند.

---

## 4. Get Average Price

### Service

```csharp
public double GetAveragePrice()
{
    return _repository.GetAll()
                      .Average(p => (double)p.Price);
}
```

### Explanation

متد `Average` میانگین قیمت محصولات را محاسبه می‌کند.

---

## 5. Group Products By Category

### Service

```csharp
public IEnumerable<IGrouping<Categories, Product>> GetProductsGroupedByCategory()
{
    return _repository.GetAll()
                      .GroupBy(p => p.Category);
}
```

### Explanation

متد `GroupBy` محصولات را بر اساس دسته‌بندی گروه‌بندی می‌کند و خروجی آن مجموعه‌ای از گروه‌ها است که هر گروه شامل محصولات یک دسته‌بندی می‌باشد.

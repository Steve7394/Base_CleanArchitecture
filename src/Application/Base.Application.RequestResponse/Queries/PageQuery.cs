﻿namespace Base.Application.RequestResponse.Queries;

/// <summary>
/// کلاس پایه جهت استفاده به عنوان مارکر برای کلاس‌هایی که پارامتر‌های ورودی را برای جستجو تعیین می‌کنند!
/// در صورتی که جستجو نیاز به صفحه بندی داشته باشد از این اینترفیس استفاده می‌شود
/// </summary>
public class PageQuery<TData> : IPageQuery<TData>
{
    /// <summary>
    /// شماره صفحه ای که باید اطلاعات از آن بارگذاری شود
    /// </summary>
    public int PageNumber { get; set; } = 1;
    /// <summary>
    /// تعداد رکورد‌های هر صفحه 
    /// </summary>
    public int PageSize { get; set; } = 10;
    /// <summary>
    /// تعداد رکورد‌هایی که باید از ابتدای نتیجه رد شود تا به رکوردهای مورد نظر برسیم
    /// </summary>
    public int SkipCount => (PageNumber - 1) * PageSize;
    /// <summary>
    /// تعیین اینکه آیا نیاز است تعداد کل رکورد‌های موجود در جستجو نیز بازگردانده شود یا خیر
    /// </summary>
    public bool NeedTotalCount { get; set; }
    /// <summary>
    /// تعیین ستونی که مرتب سازی بر اساس آن انجام می شود
    /// </summary>
    public string SortBy { get; set; } = "Id";

    /// <summary>
    /// جهت مرتب سازی داده‌ها که به صورت صعودی انجام می‌شود یا نزولی
    /// </summary>
    public bool SortAscending { get; set; }
}


/// <summary>
/// رکورد پایه جهت استفاده به عنوان مارکر برای رکورد‌هایی که پارامتر‌های ورودی را برای جستجو تعیین می‌کنند!
/// در صورتی که جستجو نیاز به صفحه بندی داشته باشد از این اینترفیس استفاده می‌شود
/// </summary>
public record PageQueryRecord<TData> : IPageQuery<TData>
{
    /// <summary>
    /// شماره صفحه ای که باید اطلاعات از آن بارگذاری شود
    /// </summary>
    public int PageNumber { get; set; } = 1;
    /// <summary>
    /// تعداد رکورد‌های هر صفحه 
    /// </summary>
    public int PageSize { get; set; } = 10;
    /// <summary>
    /// تعداد رکورد‌هایی که باید از ابتدای نتیجه رد شود تا به رکوردهای مورد نظر برسیم
    /// </summary>
    public int SkipCount => (PageNumber - 1) * PageSize;
    /// <summary>
    /// تعیین اینکه آیا نیاز است تعداد کل رکورد‌های موجود در جستجو نیز بازگردانده شود یا خیر
    /// </summary>
    public bool NeedTotalCount { get; set; }
    /// <summary>
    /// تعیین ستونی که مرتب سازی بر اساس آن انجام می شود
    /// </summary>
    public string SortBy { get; set; } = "Id";

    /// <summary>
    /// جهت مرتب سازی داده‌ها که به صورت صعودی انجام می‌شود یا نزولی
    /// </summary>
    public bool SortAscending { get; set; }
}


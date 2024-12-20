﻿namespace Heris.Application.BaseMediatR.Commands;

/// <summary>
/// کلاسی برای نمایش دستورات عمومی که با استفاده از آن‌ها عملیات‌های مختلف بر روی موجودیت‌ها انجام می‌شود.
/// این کلاس شامل اطلاعاتی است که برای عملیات‌های مختلف مانند درج، به‌روزرسانی، دریافت یا حذف داده‌ها ضروری است.
/// </summary>
/// <typeparam name="TId">نوع شناسه موجودیت</typeparam>
/// <typeparam name="TViewModel">نوع مدل داده‌ای موجودیت</typeparam>
/// <typeparam name="TResponse">نوع پاسخ عملیات</typeparam>
public class GenericCommand<TId, TViewModel, TResponse> : IRequest<TResponse>
    where TId : struct
{
    /// <summary>
    /// شناسه موجودیت
    /// </summary>
    public TId Id { get; }

    /// <summary>
    /// مدل داده‌ای برای موجودیت که در عملیات استفاده می‌شود
    /// </summary>
    public TViewModel Model { get; }

    /// <summary>
    /// سازنده کلاس GenericCommand
    /// </summary>
    /// <param name="id">شناسه موجودیت</param>
    /// <param name="model">مدل داده‌ای موجودیت</param>
    /// <param name="genericAction">نوع عملیات (درج، به‌روزرسانی، حذف و...)</param>
    public GenericCommand(TId id, TViewModel model)
    {
        Id = id;
        Model = model;
    }
}

/// <summary>
/// کلاسی برای نمایش دستورات عمومی که با استفاده از آن‌ها عملیات‌های مختلف بر روی موجودیت‌ها انجام می‌شود.
/// این کلاس شامل اطلاعاتی است که برای عملیات‌های مختلف مانند درج، به‌روزرسانی، دریافت یا حذف داده‌ها ضروری است.
/// </summary>
/// <typeparam name="TId">نوع شناسه موجودیت</typeparam>
/// <typeparam name="TViewModel">نوع مدل داده‌ای موجودیت</typeparam>
/// <typeparam name="TResponse">نوع پاسخ عملیات</typeparam>
public class GenericCommand<TId, TViewModel> : IRequest
    where TId : struct
{
    /// <summary>
    /// شناسه موجودیت
    /// </summary>
    public TId Id { get; }

    /// <summary>
    /// مدل داده‌ای برای موجودیت که در عملیات استفاده می‌شود
    /// </summary>
    public TViewModel Model { get; }

    /// <summary>
    /// سازنده کلاس GenericCommand
    /// </summary>
    /// <param name="id">شناسه موجودیت</param>
    /// <param name="model">مدل داده‌ای موجودیت</param>
    /// <param name="genericAction">نوع عملیات (درج، به‌روزرسانی، حذف و...)</param>
    public GenericCommand(TId id, TViewModel model)
    {
        Id = id;
        Model = model;
    }
}

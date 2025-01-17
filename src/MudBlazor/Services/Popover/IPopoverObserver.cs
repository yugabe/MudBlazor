﻿// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Threading.Tasks;

namespace MudBlazor;

#nullable enable
/// <summary>
/// Represents an observer for popover updates.
/// </summary>
public interface IPopoverObserver
{
    /// <summary>
    /// Gets the unique identifier of the observer.
    /// </summary>
    public Guid Id { get; }

    /// <summary>
    /// Notifies the observer of a popover collection update in <see cref="IPopoverService.ActivePopovers"/>.
    /// This notification is triggered only when <see cref="IPopoverService.CreatePopoverAsync"/>, <see cref="IPopoverService.UpdatePopoverAsync"/> or <see cref="IPopoverService.DestroyPopoverAsync"/> is called.
    /// </summary>
    /// <param name="container">The container holding the collection of updated popover holders and the corresponding operation.</param>
    /// /// <remarks>
    /// Please note that this notification will not be triggered if <see cref="IPopoverService.UpdatePopoverAsync"/>, <see cref="IPopoverService.DestroyPopoverAsync"/> return <c>false</c>.
    /// </remarks>
    public Task PopoverCollectionUpdatedNotificationAsync(PopoverHolderContainer container);
}

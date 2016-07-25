﻿//Copyright (c) Microsoft. All rights reserved. Licensed under the MIT license.
//See LICENSE in the project root for license information.

namespace Meeting_Manager_Xamarin.Models
{
    public interface IAttachmentOpener
    {
        void Open(FileAttachment attachment);
    }
}

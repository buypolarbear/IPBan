﻿// ==++==
// 
//   Copyright (c) Microsoft Corporation.  All rights reserved.
// 
// ==--==
/*============================================================
**
** Class: EventLogPermissionHolder
**
** Purpose: 
** Internal class that defines the permissions that are used 
** throughout the Event Log classes of this namespace. 
**
============================================================*/
using System;
using System.Security.Permissions;

namespace System.Diagnostics.Eventing.Reader
{

    internal class EventLogPermissionHolder
    {
        public EventLogPermissionHolder()
        {
        }

        public static EventLogPermission GetEventLogPermission()
        {
            return new EventLogPermission(EventLogPermissionAccess.Administer, ".");
        }
    }
}
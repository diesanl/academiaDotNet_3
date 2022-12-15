﻿// <auto-generated />
using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Proxies.Internal;
using WinFormsDesafio2Entity.Objects;

#pragma warning disable 219, 612, 618
#nullable enable

namespace WinFormsDesafio2Entity.CompiledModels
{
    internal partial class PedidoEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType? baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "WinFormsDesafio2Entity.Objects.Pedido",
                typeof(Pedido),
                baseEntityType);

            var id = runtimeEntityType.AddProperty(
                "id",
                typeof(int),
                propertyInfo: typeof(Pedido).GetProperty("id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Pedido).GetField("<id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw);
            id.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var clienteid = runtimeEntityType.AddProperty(
                "clienteid",
                typeof(int));
            clienteid.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var data = runtimeEntityType.AddProperty(
                "data",
                typeof(DateTime),
                propertyInfo: typeof(Pedido).GetProperty("data", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Pedido).GetField("<data>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            data.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var lazyLoader = runtimeEntityType.AddServiceProperty(
                "LazyLoader",
                propertyInfo: typeof(IProxyLazyLoader).GetProperty("LazyLoader", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var key = runtimeEntityType.AddKey(
                new[] { id });
            runtimeEntityType.SetPrimaryKey(key);

            var index = runtimeEntityType.AddIndex(
                new[] { clienteid });

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("clienteid")! },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("id")! })!,
                principalEntityType,
                deleteBehavior: DeleteBehavior.ClientCascade,
                required: true);

            var cliente = declaringEntityType.AddNavigation("cliente",
                runtimeForeignKey,
                onDependent: true,
                typeof(Cliente),
                propertyInfo: typeof(Pedido).GetProperty("cliente", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Pedido).GetField("<cliente>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                propertyAccessMode: PropertyAccessMode.Field);

            var listapedidos = principalEntityType.AddNavigation("listapedidos",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<Pedido>),
                propertyInfo: typeof(Cliente).GetProperty("listapedidos", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Cliente).GetField("<listapedidos>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                propertyAccessMode: PropertyAccessMode.Field);

            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "Pedido");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}

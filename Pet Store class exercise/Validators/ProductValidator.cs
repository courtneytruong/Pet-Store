using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using PetStoreUI;
using PetStoreProductLogic;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Cryptography.X509Certificates;
using FluentValidation;
using PetStoreProducts;

namespace Validators;

public class ProductValidator : AbstractValidator<Product>
{
    public ProductValidator()
    {
        RuleFor(product => product.Name).NotEmpty();
        RuleFor(product => product.Price).GreaterThanOrEqualTo(0);
        RuleFor(product => product.Quantity).GreaterThanOrEqualTo(0);
        RuleFor(product => product.Description).MinimumLength(10).When(product => !string.IsNullOrEmpty(product.Description));
    }
}

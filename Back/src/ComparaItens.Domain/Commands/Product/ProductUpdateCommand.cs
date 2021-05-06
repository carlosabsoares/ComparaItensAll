using ComparaItens.Domain.Entities;
using Flunt.Notifications;
using Flunt.Validations;
using System.Collections.Generic;

namespace ComparaItens.Domain.Commands.Product
{
    public class ProductUpdateCommand : Notifiable, ICommand
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }
        public int CategoryId { get; set; }
        public int ManufacturerId { get; set; }
        public int YearOfManufacture { get; set; }
        public string Image { get; set; }
        public string Folder { get; set; }
        public IList<CharacteristicDescription> CharacteristicDescription { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                    .Requires()
                    .IsGreaterThan(Id, 0, "Id", "O ManufacturerId é obrigatório")
                    .IsNotNullOrEmpty(Description, "Description", "Descrição não pode ser nulo")
                    .IsNotNullOrEmpty(Model, "Model", "Model não pode ser nulo")
                    .IsGreaterThan(CategoryId, 0, "CategoryId", "O CategoryId é obrigatório")
                    .IsGreaterThan(ManufacturerId, 0, "ManufacturerId", "O ManufacturerId é obrigatório")
                    .IsGreaterThan(YearOfManufacture, 0, "YearOfManufacture", "O YearOfManufacture é obrigatório")
                    .IsNotNullOrEmpty(Image, "Image", "Image não pode ser nulo")
                    .IsNotNullOrEmpty(Folder, "Folder", "Folder não pode ser nulo")
            );
        }
    }
}
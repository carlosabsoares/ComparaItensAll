import { Category } from './Category';
import { Manufacturer } from './Manufacturer';
import { SpecificationItem } from './SpecificationItem';

export interface Product {
  id: number;
  description: string;
  manufecturerId: number;
  model: string;
  categoryId: number;
  yearOfManufacture: number;
  image: string;
  folder: string;
  manufacturer: Manufacturer;
  category: Category;
  specificationItem: SpecificationItem[];
}

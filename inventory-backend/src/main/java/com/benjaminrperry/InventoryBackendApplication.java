package com.benjaminrperry;

import java.util.Arrays;
import java.util.List;

import org.springframework.boot.CommandLineRunner;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.annotation.Bean;

import com.benjaminrperry.category.Category;
import com.benjaminrperry.category.CategoryRepository;
import com.benjaminrperry.product.Product;
import com.benjaminrperry.product.ProductRepository;

@SpringBootApplication
public class InventoryBackendApplication {

	public static void main(String[] args) {
		SpringApplication.run(InventoryBackendApplication.class, args);
	}
	
	@Bean
	public CommandLineRunner preloadData(CategoryRepository catRepo,ProductRepository prodRepo) {
		return (args)->{
			Category yarn = new Category(-1,"Yarn","YRN");
			
			List<Category> cats = Arrays.asList(
					yarn
					);
			cats = catRepo.saveAll(cats);
			List<Product> prods = Arrays.asList(
					new Product("YRN0001", "Test Yarn", cats.get(0))
					);
			prodRepo.saveAll(prods);
			
		};
	}

}

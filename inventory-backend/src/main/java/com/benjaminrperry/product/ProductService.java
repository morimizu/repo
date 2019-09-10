package com.benjaminrperry.product;

import java.net.URI;
import java.util.List;
import java.util.NoSuchElementException;
import java.util.Optional;

import org.h2.util.StringUtils;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.servlet.support.ServletUriComponentsBuilder;

import com.benjaminrperry.ItemNotFoundException;
import com.benjaminrperry.category.Category;
import com.benjaminrperry.category.CategoryRepository;

@RestController
public class ProductService {
	
	Logger logger = LoggerFactory.getLogger(ProductService.class);
	
	@Autowired
	private ProductRepository prodRepo;
	@Autowired
	private CategoryRepository catRepo;

	@GetMapping("/products")
	public List<Product> getAllProducts(){
		return prodRepo.findAll();
	}
	@GetMapping("/products/{id}")
	public Product getProduct(@PathVariable long id){
		Optional<Product> prod =  prodRepo.findById(id);
		if(prod.isEmpty()) {
			throw new ItemNotFoundException("there is no product with an id of "+id);
		}
		return prod.get();
	}
	@GetMapping("/category/{id}/products")
	public List<Product> getCategoryProducts(@PathVariable String id){
		Category c = null;
		boolean isAbriv = false;
		try {
			//logger.info("Category ID:"+id);
			if(StringUtils.isNumber(id)) {
				c = catRepo.findById(Long.valueOf(id)).get();
			}else {
				isAbriv = true;
				c = this.catRepo.findCategoryByAbriv(id).get();
				
			}
		} catch (NoSuchElementException e) {
			if(isAbriv) {
				throw new ItemNotFoundException("There is no Category with an abriviation of "+id);
			}else {
				throw new ItemNotFoundException("There is no Category with the id of "+id);
			}
			
		}
		List<Product> prods = this.prodRepo.findProductsByCategory(c);
		return prods;
	}
	
	@PostMapping("/products")
	public ResponseEntity<Product> addProduct(@RequestBody Product prod){
		Product newProd = prodRepo.save(prod);
		URI location = ServletUriComponentsBuilder.fromCurrentRequest().path("/{id}").buildAndExpand(newProd.getId()).toUri();
		return ResponseEntity.created(location).build();
	}
	
	@PutMapping("/products/{id}")
	public ResponseEntity<Product> updateProduct(@PathVariable long id, @RequestBody Product prod){
		Optional<Product> loaded = prodRepo.findById(id);
		if(!loaded.isPresent()) {
			throw new ItemNotFoundException("Cannot find product with the id of "+id);
		}
		loaded.get().updateProperties(prod);
		return ResponseEntity.ok(loaded.get());
	}
	
	@DeleteMapping("/products/{id}")
	public void deleteProduct(@PathVariable long id) {
		if(!prodRepo.existsById(id)) {
			throw new ItemNotFoundException("Cannot find product with the id of "+id);
		}
		prodRepo.deleteById(id);
	}
}

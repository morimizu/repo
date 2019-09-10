package com.benjaminrperry.category;

import java.net.URI;
import java.util.List;
import java.util.NoSuchElementException;

import org.h2.util.StringUtils;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.transaction.annotation.Transactional;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.servlet.support.ServletUriComponentsBuilder;

import com.benjaminrperry.ItemNotFoundException;

@RestController
@Transactional
public class CategoryService {
	@Autowired
	private CategoryRepository repo;

	@GetMapping("/category")
	public List<Category> getAllCategories(){
		return this.repo.findAll();
	}
	@GetMapping("/category/{id}")
	public Category getCategoryById(@PathVariable String id){
		Category c = null;
		boolean isAbriv = false;
		try {
			if(StringUtils.isNumber(id)) {
				c = this.repo.findById(Long.valueOf(id)).get();
			}else {
				isAbriv = true;
				c = this.repo.findCategoryByAbriv(id).get();
				
			}
		} catch (NoSuchElementException e) {
			if(isAbriv) {
				throw new ItemNotFoundException("There is no Category with an abriviation of "+id);
			}else {
				throw new ItemNotFoundException("There is no Category with the id of "+id);
			}
			
		}
		return c;
	}
	
	@PostMapping("/category")
	public ResponseEntity<Category> addCategory(@RequestBody Category category){
		Category saved = this.repo.save(category);
		URI location = ServletUriComponentsBuilder.fromCurrentRequest().path("/{id}").buildAndExpand(saved.getId()).toUri();
		return ResponseEntity.created(location).build();
	}
	@PutMapping("/category/{id}")
	public ResponseEntity<Category> updateCategory(@PathVariable long id,@RequestBody Category category){
		Category loaded = getCategoryById(String.valueOf(id));
		loaded.setName(category.getName());
		loaded.setAbriv(category.getAbriv());
		Category saved = this.repo.save(loaded);
		return ResponseEntity.ok(saved);
	}
	@DeleteMapping("/category/{id}")
	public void deleteCategory(@PathVariable long id) {
		this.repo.deleteById(id);
	}
}

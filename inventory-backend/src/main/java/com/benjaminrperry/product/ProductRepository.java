package com.benjaminrperry.product;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;

import com.benjaminrperry.category.Category;

public interface ProductRepository extends JpaRepository<Product, Long> {
	List<Product> findProductsByCategory(Category category);

}

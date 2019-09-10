package com.benjaminrperry.category;

import java.util.Optional;

import org.springframework.data.jpa.repository.JpaRepository;

public interface CategoryRepository extends JpaRepository<Category, Long> {
	
	public Optional<Category> findCategoryByAbriv(String abriv);

}

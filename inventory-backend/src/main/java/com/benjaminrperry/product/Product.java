package com.benjaminrperry.product;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;
import javax.persistence.ManyToOne;

import com.benjaminrperry.category.Category;

@Entity
public class Product {
	@Id
	@GeneratedValue
	private long id;
	
	private String productNumber;
	
	private String description;
	
	@ManyToOne
	private Category category;

	public Product(){}
	
	public Product(String productNumber, String description, Category category) {
		super();
		this.productNumber = productNumber;
		this.description = description;
		this.category = category;
	}

	/**
	 * @return the id
	 */
	public long getId() {
		return id;
	}

	/**
	 * @param id the id to set
	 */
	public void setId(long id) {
		this.id = id;
	}

	/**
	 * @return the productNumber
	 */
	public String getProductNumber() {
		return productNumber;
	}

	/**
	 * @param productNumber the productNumber to set
	 */
	public void setProductNumber(String productNumber) {
		this.productNumber = productNumber;
	}

	/**
	 * @return the description
	 */
	public String getDescription() {
		return description;
	}

	/**
	 * @param description the description to set
	 */
	public void setDescription(String description) {
		this.description = description;
	}

	/**
	 * @return the category
	 */
	public Category getCategory() {
		return category;
	}

	/**
	 * @param category the category to set
	 */
	public void setCategory(Category category) {
		this.category = category;
	}
	public void updateProperties(Product toCopy) {
		this.productNumber = toCopy.getProductNumber();
		this.description = toCopy.description;
		this.productNumber = toCopy.productNumber;
	}

}

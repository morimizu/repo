package com.benjaminrperry.category;

import java.util.List;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;
import javax.persistence.OneToMany;

import com.benjaminrperry.product.Product;

@Entity
public class Category {
	@Id
	@GeneratedValue
	private long id;
	
	private String name ="";
	
	private String abriv ="";
	
	protected Category() {
		
	}

	public Category(long id, String name, String abriv) {
		super();
		this.id = id;
		this.name = name;
		this.abriv = abriv;
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
	 * @return the name
	 */
	public String getName() {
		return name;
	}

	/**
	 * @param name the name to set
	 */
	public void setName(String name) {
		this.name = name;
	}

	/**
	 * @return the abriv
	 */
	public String getAbriv() {
		return abriv;
	}

	/**
	 * @param abriv the abriv to set
	 */
	public void setAbriv(String abriv) {
		this.abriv = abriv;
	}
	


}

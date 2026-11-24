cmake_minimum_required(VERSION 4.4)
project(DATA_Lib)

add_library(data SHARED)

target_sources(
	data
	PRIVATE
		src/data.c
	PUBLIC
		includes/data.h
)

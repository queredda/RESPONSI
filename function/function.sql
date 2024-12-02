CREATE or REPLACE function add_karyawan(
	in_id_karyawan char(10),
	in_nama char(100),
	in_id_dep char(10)
)
RETURNS integer AS $$
BEGIN
	if EXISTS (
		SELECT 1 FROM karyawan 
		WHERE id_karyawan = in_id_karyawan
	) 
	THEN RETURN 409;
	ELSE
		INSERT INTO karyawan (id_karyawan, nama, id_dep)
		VALUES
		(in_id_karyawan, in_nama, in_id_dep);
		RETURN 201;
	END IF;
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION edit_karyawan(
	in_id_karyawan char(10),
	in_nama char(100),
	in_id_dep char(10)
)
RETURNS integer AS $$
BEGIN
	IF EXISTS (
		SELECT 1 FROM karyawan
		WHERE id_karyawan = in_id_karyawan
	)
	THEN 
		UPDATE karyawan
		SET nama = in_nama, id_dep = in_id_dep
		WHERE id_karyawan = in_id_karyawan;
		RETURN 200;
	ELSE 
		RETURN 404;
	END IF;
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION delete_karyawan(
	in_id_karyawan char(10)
)
RETURNS INTEGER AS $$
BEGIN
	IF EXISTS (
		SELECT 1 
		FROM karyawan
		WHERE id_karyawan = in_id_karyawan
	)
	THEN
		DELETE FROM karyawan
		WHERE id_karyawan = in_id_karyawan;
		RETURN 204;
	ELSE
		RETURN 404;
	END IF;
END;
$$ LANGUAGE plpgsql;